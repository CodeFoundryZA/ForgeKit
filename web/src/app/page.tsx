"use client";

import Link from "next/link";

import { ApiEndpoints } from "@/api/endpoints";

export default function Home() {

  return (
    <div className="min-h-screen bg-zinc-950 text-zinc-50">
      <main className="mx-auto flex w-full max-w-3xl flex-col gap-8 px-6 py-16">
        <header className="space-y-3">
          <p className="text-sm uppercase tracking-[0.3em] text-zinc-400">ForgeKit API Demo</p>
          <h1 className="text-3xl font-semibold">Endpoints</h1>
          <p className="text-base text-zinc-300">Demo pages for the <code>TestController</code> endpoints.</p>
        </header>

        <section className="rounded-2xl border border-zinc-800 bg-zinc-900/70 p-6">
          <div className="flex items-center justify-between gap-4">
            <div>
              <h2 className="text-lg font-semibold">Ping</h2>
              <p className="text-sm text-zinc-400">
                GET <code>{ApiEndpoints.Test.Ping}</code>
              </p>
            </div>
            <Link
              href="/ping"
              className="rounded-full bg-white px-4 py-2 text-sm font-medium text-zinc-900"
            >
              Go to ping page
            </Link>
          </div>
          <p className="mt-4 text-sm text-zinc-200">
            Navigate to the ping page to call this endpoint and see the response.
          </p>
        </section>

        <section className="rounded-2xl border border-zinc-800 bg-zinc-900/70 p-6">
          <div className="flex items-center justify-between gap-4">
            <div>
              <h2 className="text-lg font-semibold">Echo</h2>
              <p className="text-sm text-zinc-400">
                POST <code>{ApiEndpoints.Test.Echo}</code>
              </p>
            </div>
            <Link
              href="/echo"
              className="rounded-full bg-white px-4 py-2 text-sm font-medium text-zinc-900"
            >
              Go to echo page
            </Link>
          </div>
          <p className="mt-4 text-sm text-zinc-200">
            Navigate to the echo page to call this endpoint and see the response.
          </p>
        </section>
      </main>
    </div>
  );
}
