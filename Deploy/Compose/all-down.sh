#!/bin/bash
docker-compose -f shared.yml -f cbs-admin.yml -f cbs-reporting.yml -f cbs-usermanagement.yml down