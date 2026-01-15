/**
 * API Endpoints
 * Type-safe endpoint constants extracted from the OpenAPI schema
 */

export class ApiEndpoints {
  static readonly Healthz = "/healthz" as const;
  static readonly Test = {
    Ping: "/api/test/ping" as const,
    Echo: "/api/test/echo" as const,
  } as const;
}
