import createClient from "openapi-fetch";
import type { paths } from "./openapi";

export const apiClient = createClient<paths>({
  baseUrl: "http://localhost:5075",
});
