#!/bin/bash
input="JpgMetadataEditor.csproj"
while IFS= read -r line
do
  echo "$line"
done < "$input"

pause