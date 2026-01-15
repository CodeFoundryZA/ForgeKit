# TestApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**apiTestEchoPost**](TestApi.md#apitestechopost) | **POST** /api/test/echo |  |
| [**apiTestPingGet**](TestApi.md#apitestpingget) | **GET** /api/test/ping |  |



## apiTestEchoPost

> TestEchoResponse apiTestEchoPost(testEchoRequest)



### Example

```ts
import {
  Configuration,
  TestApi,
} from 'forgekit-web-client';
import type { ApiTestEchoPostRequest } from 'forgekit-web-client';

async function example() {
  console.log("🚀 Testing forgekit-web-client SDK...");
  const api = new TestApi();

  const body = {
    // TestEchoRequest (optional)
    testEchoRequest: ...,
  } satisfies ApiTestEchoPostRequest;

  try {
    const data = await api.apiTestEchoPost(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **testEchoRequest** | [TestEchoRequest](TestEchoRequest.md) |  | [Optional] |

### Return type

[**TestEchoResponse**](TestEchoResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: `application/json`, `text/json`, `application/*+json`
- **Accept**: `text/plain`, `application/json`, `text/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## apiTestPingGet

> TestPingResponse apiTestPingGet()



### Example

```ts
import {
  Configuration,
  TestApi,
} from 'forgekit-web-client';
import type { ApiTestPingGetRequest } from 'forgekit-web-client';

async function example() {
  console.log("🚀 Testing forgekit-web-client SDK...");
  const api = new TestApi();

  try {
    const data = await api.apiTestPingGet();
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

[**TestPingResponse**](TestPingResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `text/plain`, `application/json`, `text/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)

