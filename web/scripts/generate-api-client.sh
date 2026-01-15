#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
API_SPEC_URL=${API_SPEC_URL:-http://localhost:5075/swagger/v1/swagger.json}
OUTPUT_DIR="$ROOT_DIR/src/api/generated"
TEMP_DIR=$(mktemp -d)

echo "Downloading OpenAPI spec from $API_SPEC_URL..."
curl -fsSL "$API_SPEC_URL" -o "$TEMP_DIR/openapi.json"
if [ ! -s "$TEMP_DIR/openapi.json" ]; then
  echo "OpenAPI spec download failed or empty." >&2
  exit 1
fi

echo "Generating TypeScript fetch client with OpenAPI Generator..."
rm -rf "$OUTPUT_DIR"
mkdir -p "$OUTPUT_DIR"

npx @openapitools/openapi-generator-cli generate \
  -i "$TEMP_DIR/openapi.json" \
  -g typescript-fetch \
  -o "$OUTPUT_DIR" \
  --additional-properties=npmName=forgekit-web-client,supportsES6=true,typescriptThreePlus=true

rm -rf "$TEMP_DIR"
echo "Client generated into $OUTPUT_DIR"

