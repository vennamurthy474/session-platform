#!/bin/bash
echo "Starting session-api service..."

systemctl daemon-reload
systemctl start session-api
systemctl status session-api --no-pager
