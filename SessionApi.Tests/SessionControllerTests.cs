using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using SessionApi.Controllers;
using Xunit;

namespace SessionApi.Tests
{
    public class SessionControllerTests
    {
        [Fact]
        public void GetSession_ReturnsOkWithSessionObject()
        {
            var controller = new SessionController();
            var result = controller.GetSession("session-xyz");

            var ok = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, ok.StatusCode);

            var value = ok.Value ?? throw new Exception("Result value is null");
            var type = value.GetType();

            string GetString(string name) => (string?)type.GetProperty(name, BindingFlags.Public | BindingFlags.Instance)?.GetValue(value) ?? throw new Exception($"Property '{name}' missing or null");

            var sessionId = GetString("sessionId");
            var status = GetString("status");
            var message = GetString("message");

            Assert.Equal("session-xyz", sessionId);
            Assert.Equal("active", status);
            Assert.Equal("Redis integration coming in Step 4", message);

            var timestampProp = type.GetProperty("timestamp", BindingFlags.Public | BindingFlags.Instance);
            Assert.NotNull(timestampProp);
            var timestampValue = timestampProp.GetValue(value);
            Assert.IsType<DateTime>(timestampValue);
        }
    }
}
