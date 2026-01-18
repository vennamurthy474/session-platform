#!/bin/bash
echo "Stopping session-api service if running..."
systemctl stop session-api || true
