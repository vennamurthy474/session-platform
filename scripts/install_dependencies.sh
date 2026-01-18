#!/bin/bash
echo "Preparing application directory..."

mkdir -p /var/www/session-api
chown -R ec2-user:ec2-user /var/www/session-api
