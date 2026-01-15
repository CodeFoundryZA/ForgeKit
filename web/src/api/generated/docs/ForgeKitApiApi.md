# ForgeKitApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**healthzGet**](ForgeKitApiApi.md#healthzget) | **GET** /healthz |  |



## healthzGet

> healthzGet()



### Example

```ts
import {
  Configuration,
  ForgeKitApiApi,
} from 'forgekit-web-client';
import type { HealthzGetRequest } from 'forgekit-web-client';

async function example() {
  console.log("🚀 Testing forgekit-web-client SDK...");
  const api = new ForgeKitApiApi();

  try {
    const data = await api.healthzGet();
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters

This endpoint does not need any parameter.

### Return type

`void` (Empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)

