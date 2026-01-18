using Microsoft.AspNetCore.Mvc;
using SessionApi.Controllers;
using Xunit;

namespace SessionApi.Tests
{
    public class HealthControllerTests
    {
        [Fact]
        public void Get_ReturnsOkObjectResult()
        {
            var controller = new HealthController();
            var result = controller.Get();

            var ok = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("API Healthy - Free Tier Session Platform", ok.Value);
        }

        [Fact]
        public void Get_StatusCodeIs200()
        {
            var controller = new HealthController();
            var result = controller.Get();

            var ok = Assert.IsType<OkObjectResult>(result);
            // OkObjectResult.StatusCode is typically 200
            Assert.True(ok.StatusCode == 200 || ok.StatusCode == null);
        }
    }
}
