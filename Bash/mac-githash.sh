#! /usr/bin/env sh

SHORT_HASH="$( git log --pretty=format:'%h' -n 1 )"
echo $SHORT_HASH
