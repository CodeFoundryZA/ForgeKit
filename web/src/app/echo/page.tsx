"use client";

import { useState } from "react";
import Link from "next/link";

import { apiClient } from "@/api/client";
import { ApiEndpoints } from "@/api/endpoints";

type EchoState = {
  status: "idle" | "loading" | "success" | "error";
  message?: string;
  count?: number;
  error?: string;
};

export default function EchoPage() {
  const [echoState, setEchoState] = useState<EchoState>({ status: "idle" });

  async function runEcho() {
    setEchoState({ status: "loading" });
    const { data, error } = await apiClient.POST(ApiEndpoints.Test.Echo, {
      body: { message: "hello from forgekit-web", count: 3 },
    });

    if (error || !data) {
      setEchoState({
        status: "error",
        error: `Failed to reach ${ApiEndpoints.Test.Echo}`,
      });
      return;
    }

    setEchoState({
      status: "success",
      message: data.message ?? undefined,
      count: data.count,
    });
  }

  return (
    <div className="min-h-screen bg-zinc-950 text-zinc-50">
      <main className="mx-auto flex w/full max-w-3xl flex-col gap-8 px-6 py-16">
        <header className="space-y-3">
          <p className="text-sm uppercase tracking-[0.3em] text-zinc-400">
            ForgeKit API Demo
          </p>
          <h1 className="text-3xl font-semibold">Echo</h1>
          <p className="text-base text-zinc-300">
            Calls the <code>{ApiEndpoints.Test.Echo}</code> endpoint.
          </p>
          <p className="text-sm text-zinc-400">
            <Link href="/" className="underline underline-offset-4">
              Back to home
            </Link>
          </p>
        </header>

        <section className="rounded-2xl border border-zinc-800 bg-zinc-900/70 p-6">
          <div className="flex items-center justify-between gap-4">
            <button
              className="rounded-full bg-white px-4 py-2 text-sm font-medium text-zinc-900"
              onClick={runEcho}
              type="button"
            >
              Send
            </button>
          </div>
          <div className="mt-4 text-sm text-zinc-200">
            {echoState.status === "loading" && "Loading..."}
            {echoState.status === "error" && echoState.error}
            {echoState.status === "success" && (
              <div className="space-y-1">
                <div>Message: {echoState.message}</div>
                <div>Count: {echoState.count}</div>
              </div>
            )}
            {echoState.status === "idle" && "Click send to call echo."}
          </div>
        </section>
      </main>
    </div>
  );
}

