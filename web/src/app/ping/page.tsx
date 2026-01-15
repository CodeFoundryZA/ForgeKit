"use client";

import { useEffect, useState } from "react";
import Link from "next/link";

import { apiClient } from "@/api/client";
import { ApiEndpoints } from "@/api/endpoints";

type PingState = {
  status: "idle" | "loading" | "success" | "error";
  message?: string;
  at?: string;
  error?: string;
};

export default function PingPage() {
  const [pingState, setPingState] = useState<PingState>({ status: "idle" });

  async function loadPing() {
    setPingState({ status: "loading" });
    const { data, error } = await apiClient.GET(ApiEndpoints.Test.Ping);

    if (error || !data) {
      setPingState({
        status: "error",
        error: `Failed to reach ${ApiEndpoints.Test.Ping}`,
      });
      return;
    }

    setPingState({
      status: "success",
      message: data.status ?? undefined,
      at: data.timestamp,
    });
  }

  useEffect(() => {
    loadPing();
  }, []);

  return (
    <div className="min-h-screen bg-zinc-950 text-zinc-50">
      <main className="mx-auto flex w-full max-w-3xl flex-col gap-8 px-6 py-16">
        <header className="space-y-3">
          <p className="text-sm uppercase tracking-[0.3em] text-zinc-400">
            ForgeKit API Demo
          </p>
          <h1 className="text-3xl font-semibold">Ping</h1>
          <p className="text-base text-zinc-300">
            Calls the <code>{ApiEndpoints.Test.Ping}</code> endpoint.
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
              onClick={loadPing}
              type="button"
            >
              Refresh
            </button>
          </div>
          <div className="mt-4 text-sm text-zinc-200">
            {pingState.status === "loading" && "Loading..."}
            {pingState.status === "error" && pingState.error}
            {pingState.status === "success" && (
              <div className="space-y-1">
                <div>Status: {pingState.message}</div>
                <div>Timestamp: {pingState.at}</div>
              </div>
            )}
            {pingState.status === "idle" && "Click refresh to call ping."}
          </div>
        </section>
      </main>
    </div>
  );
}

