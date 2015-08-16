#! /usr/bin/env sh

CI_TOKEN="$1"
BUNDLE_PATH="$2"

# Uploading to AppBlade...
curl -# 
-H "Authorization: Bearer $CI_TOKEN" 
-F "version[bundle]=@$BUNDLE_PATH" \
https://appblade.com/api/3/versions