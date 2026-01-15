using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForgeKit.DbMigrator.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agent_class",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    version = table.Column<string>(type: "text", nullable: false),
                    kind = table.Column<string>(type: "text", nullable: true),
                    default_model = table.Column<string>(type: "text", nullable: true),
                    capabilities = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    default_config = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agent_class", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "integration_definition",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    key = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    category = table.Column<string>(type: "text", nullable: true),
                    auth_type = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    icon = table.Column<string>(type: "text", nullable: true),
                    capabilities_json = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    config_schema_json = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    kind = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_integration_definition", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "plan",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    token_limit = table.Column<long>(type: "bigint", nullable: false),
                    stripe_product_id = table.Column<string>(type: "text", nullable: true),
                    stripe_price_id = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tenant",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    logo_file_id = table.Column<Guid>(type: "uuid", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    vanity_domain = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    properties = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    stripe_customer_id = table.Column<string>(type: "text", nullable: true),
                    country_code = table.Column<string>(type: "text", nullable: true),
                    default_currency = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tenant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "token_pack",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    code = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    tokens = table.Column<long>(type: "bigint", nullable: false),
                    currency = table.Column<string>(type: "text", nullable: true),
                    unit_amount = table.Column<long>(type: "bigint", nullable: false),
                    stripe_price_id = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_token_pack", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "agent",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<string>(type: "text", nullable: true),
                    concurrency_limit = table.Column<int>(type: "integer", nullable: false),
                    default_model = table.Column<string>(type: "text", nullable: true),
                    config = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agent", x => x.id);
                    table.ForeignKey(
                        name: "FK_agent_agent_class_class_id",
                        column: x => x.class_id,
                        principalTable: "agent_class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_agent_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "charge",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    stripe_charge_id = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    amount = table.Column<long>(type: "bigint", nullable: false),
                    currency = table.Column<string>(type: "text", nullable: true),
                    failure_code = table.Column<string>(type: "text", nullable: true),
                    failure_message = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_charge", x => x.id);
                    table.ForeignKey(
                        name: "FK_charge_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "file_entity",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    storage_key = table.Column<string>(type: "text", nullable: false),
                    original_filename = table.Column<string>(type: "text", nullable: false),
                    mime_type = table.Column<string>(type: "text", nullable: false),
                    size_bytes = table.Column<long>(type: "bigint", nullable: false),
                    checksum = table.Column<string>(type: "text", nullable: true),
                    metadata = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file_entity", x => x.id);
                    table.ForeignKey(
                        name: "FK_file_entity_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "organisation",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    trading_name = table.Column<string>(type: "text", nullable: true),
                    primary_domain = table.Column<string>(type: "text", nullable: true),
                    country_code = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    vat_number = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisation", x => x.id);
                    table.ForeignKey(
                        name: "FK_organisation_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payment_method",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    stripe_payment_method_id = table.Column<string>(type: "text", nullable: true),
                    type = table.Column<string>(type: "text", nullable: true),
                    brand = table.Column<string>(type: "text", nullable: true),
                    last4 = table.Column<string>(type: "text", nullable: true),
                    exp_month = table.Column<int>(type: "integer", nullable: true),
                    exp_year = table.Column<int>(type: "integer", nullable: true),
                    is_default = table.Column<bool>(type: "boolean", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_method", x => x.id);
                    table.ForeignKey(
                        name: "FK_payment_method_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.id);
                    table.ForeignKey(
                        name: "FK_role_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "token_wallet",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    balance_cached_tokens = table.Column<long>(type: "bigint", nullable: false),
                    pending_hold_tokens = table.Column<long>(type: "bigint", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_token_wallet", x => x.id);
                    table.ForeignKey(
                        name: "FK_token_wallet_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    default_tenant_id = table.Column<Guid>(type: "uuid", nullable: true),
                    user_name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: false),
                    password_hash = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    timezone = table.Column<string>(type: "text", nullable: true),
                    locale = table.Column<string>(type: "text", nullable: true),
                    properties = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    avatar_file_id = table.Column<Guid>(type: "uuid", nullable: true),
                    signup_source = table.Column<string>(type: "text", nullable: true),
                    last_seen = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_tenant_default_tenant_id",
                        column: x => x.default_tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    organisation_id = table.Column<Guid>(type: "uuid", nullable: true),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    meta = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    industry = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.id);
                    table.ForeignKey(
                        name: "FK_client_organisation_organisation_id",
                        column: x => x.organisation_id,
                        principalTable: "organisation",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_client_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contact_person",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    organisation_id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    fullname = table.Column<string>(type: "text", nullable: true),
                    title = table.Column<string>(type: "text", nullable: true),
                    role = table.Column<string>(type: "text", nullable: true),
                    notes = table.Column<string>(type: "text", nullable: true),
                    is_primary = table.Column<bool>(type: "boolean", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    preferred_channel = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_person", x => x.id);
                    table.ForeignKey(
                        name: "FK_contact_person_organisation_organisation_id",
                        column: x => x.organisation_id,
                        principalTable: "organisation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contact_person_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vendor",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    organisation_id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    speciality = table.Column<string>(type: "text", nullable: true),
                    bank_account_ref = table.Column<string>(type: "text", nullable: true),
                    meta = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor", x => x.id);
                    table.ForeignKey(
                        name: "FK_vendor_organisation_organisation_id",
                        column: x => x.organisation_id,
                        principalTable: "organisation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vendor_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subscription",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    plan_id = table.Column<Guid>(type: "uuid", nullable: true),
                    stripe_subscription_id = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    collection_method = table.Column<string>(type: "text", nullable: true),
                    default_payment_method_id = table.Column<Guid>(type: "uuid", nullable: true),
                    current_period_start = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    current_period_end = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    external_customer_id = table.Column<string>(type: "text", nullable: true),
                    external_sub_id = table.Column<string>(type: "text", nullable: true),
                    trial_end = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscription", x => x.id);
                    table.ForeignKey(
                        name: "FK_subscription_payment_method_default_payment_method_id",
                        column: x => x.default_payment_method_id,
                        principalTable: "payment_method",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_subscription_plan_plan_id",
                        column: x => x.plan_id,
                        principalTable: "plan",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_subscription_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "role_permission",
                columns: table => new
                {
                    role_id = table.Column<Guid>(type: "uuid", nullable: false),
                    permission = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_permission", x => new { x.role_id, x.permission });
                    table.ForeignKey(
                        name: "FK_role_permission_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "auto_topup_settings",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    wallet_id = table.Column<Guid>(type: "uuid", nullable: false),
                    enabled = table.Column<bool>(type: "boolean", nullable: false),
                    treshold_tokens = table.Column<long>(type: "bigint", nullable: false),
                    token_pack_id = table.Column<Guid>(type: "uuid", nullable: false),
                    pack_multiplier = table.Column<int>(type: "integer", nullable: false),
                    default_payment_method_id = table.Column<Guid>(type: "uuid", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auto_topup_settings", x => x.id);
                    table.ForeignKey(
                        name: "FK_auto_topup_settings_payment_method_default_payment_method_id",
                        column: x => x.default_payment_method_id,
                        principalTable: "payment_method",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_auto_topup_settings_token_pack_token_pack_id",
                        column: x => x.token_pack_id,
                        principalTable: "token_pack",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_auto_topup_settings_token_wallet_wallet_id",
                        column: x => x.wallet_id,
                        principalTable: "token_wallet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tenant_invite",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    expires_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    accepted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    invited_by_user_id = table.Column<Guid>(type: "uuid", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tenant_invite", x => x.id);
                    table.ForeignKey(
                        name: "FK_tenant_invite_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tenant_invite_user_invited_by_user_id",
                        column: x => x.invited_by_user_id,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "tenant_membership",
                columns: table => new
                {
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    role_id = table.Column<Guid>(type: "uuid", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tenant_membership", x => new { x.tenant_id, x.user_id });
                    table.ForeignKey(
                        name: "FK_tenant_membership_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tenant_membership_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tenant_membership_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_identity",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    provider = table.Column<string>(type: "text", nullable: false),
                    external_id = table.Column<string>(type: "text", nullable: false),
                    email_verified_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_identity", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_identity_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_settings",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    theme = table.Column<string>(type: "text", nullable: true),
                    notify_on_ticket_assigned = table.Column<bool>(type: "boolean", nullable: false),
                    notify_on_review_assigned = table.Column<bool>(type: "boolean", nullable: false),
                    notify_on_publish = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_settings", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_user_settings_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "board",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    sort_order = table.Column<int>(type: "integer", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_board", x => x.id);
                    table.ForeignKey(
                        name: "FK_board_client_client_id",
                        column: x => x.client_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_board_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "brand_profile",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    pallete_json = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    fonts_json = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    voice_json = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand_profile", x => x.id);
                    table.ForeignKey(
                        name: "FK_brand_profile_client_client_id",
                        column: x => x.client_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_brand_profile_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "provider_connection",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    integration_definition_id = table.Column<Guid>(type: "uuid", nullable: false),
                    provider = table.Column<string>(type: "text", nullable: true),
                    account_external_id = table.Column<string>(type: "text", nullable: true),
                    account_label = table.Column<string>(type: "text", nullable: true),
                    credential_ref = table.Column<string>(type: "text", nullable: true),
                    token_expires_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    scopes = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    meta = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provider_connection", x => x.id);
                    table.ForeignKey(
                        name: "FK_provider_connection_client_client_id",
                        column: x => x.client_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_provider_connection_integration_definition_integration_defi~",
                        column: x => x.integration_definition_id,
                        principalTable: "integration_definition",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_provider_connection_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "invoice",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    stripe_invoice_id = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    amount_due = table.Column<long>(type: "bigint", nullable: false),
                    amount_paid = table.Column<long>(type: "bigint", nullable: false),
                    amount_remaining = table.Column<long>(type: "bigint", nullable: false),
                    due_date = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    paid_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    hosted_invoice_url = table.Column<string>(type: "text", nullable: true),
                    subscription_id = table.Column<Guid>(type: "uuid", nullable: true),
                    collection_method = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoice", x => x.id);
                    table.ForeignKey(
                        name: "FK_invoice_subscription_subscription_id",
                        column: x => x.subscription_id,
                        principalTable: "subscription",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_invoice_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subscription_item",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    subscription_id = table.Column<Guid>(type: "uuid", nullable: false),
                    plan_id = table.Column<Guid>(type: "uuid", nullable: true),
                    stripe_subscription_item_id = table.Column<string>(type: "text", nullable: true),
                    quantity = table.Column<long>(type: "bigint", nullable: false),
                    stripe_price_id = table.Column<string>(type: "text", nullable: true),
                    is_metered = table.Column<bool>(type: "boolean", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscription_item", x => x.id);
                    table.ForeignKey(
                        name: "FK_subscription_item_plan_plan_id",
                        column: x => x.plan_id,
                        principalTable: "plan",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_subscription_item_subscription_subscription_id",
                        column: x => x.subscription_id,
                        principalTable: "subscription",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "board_column",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    board_id = table.Column<Guid>(type: "uuid", nullable: false),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    slug = table.Column<string>(type: "text", nullable: true),
                    wip_limit = table.Column<int>(type: "integer", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_board_column", x => x.id);
                    table.ForeignKey(
                        name: "FK_board_column_board_board_id",
                        column: x => x.board_id,
                        principalTable: "board",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_board_column_client_client_id",
                        column: x => x.client_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "brand_asset",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    brand_profile_id = table.Column<Guid>(type: "uuid", nullable: false),
                    file_id = table.Column<Guid>(type: "uuid", nullable: false),
                    asset_type = table.Column<string>(type: "text", nullable: true),
                    label = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand_asset", x => x.id);
                    table.ForeignKey(
                        name: "FK_brand_asset_brand_profile_brand_profile_id",
                        column: x => x.brand_profile_id,
                        principalTable: "brand_profile",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_brand_asset_file_entity_file_id",
                        column: x => x.file_id,
                        principalTable: "file_entity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_brand_asset_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "provider_resource",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    provider_connection_id = table.Column<Guid>(type: "uuid", nullable: false),
                    resource_type = table.Column<string>(type: "text", nullable: true),
                    external_type = table.Column<string>(type: "text", nullable: true),
                    display_name = table.Column<string>(type: "text", nullable: true),
                    is_default = table.Column<bool>(type: "boolean", nullable: false),
                    metadata = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provider_resource", x => x.id);
                    table.ForeignKey(
                        name: "FK_provider_resource_provider_connection_provider_connection_id",
                        column: x => x.provider_connection_id,
                        principalTable: "provider_connection",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_provider_resource_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    column_id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    type = table.Column<string>(type: "text", nullable: true),
                    priority = table.Column<string>(type: "text", nullable: true),
                    owner_user_id = table.Column<Guid>(type: "uuid", nullable: true),
                    assignee_user_id = table.Column<Guid>(type: "uuid", nullable: true),
                    due_date = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    scheduled_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    channel = table.Column<string>(type: "text", nullable: true),
                    automation_state = table.Column<string>(type: "text", nullable: true),
                    position = table.Column<int>(type: "integer", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.id);
                    table.ForeignKey(
                        name: "FK_ticket_board_column_column_id",
                        column: x => x.column_id,
                        principalTable: "board_column",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_client_client_id",
                        column: x => x.client_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_user_assignee_user_id",
                        column: x => x.assignee_user_id,
                        principalTable: "user",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ticket_user_owner_user_id",
                        column: x => x.owner_user_id,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ai_run",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ticket_id = table.Column<Guid>(type: "uuid", nullable: false),
                    agent_id = table.Column<Guid>(type: "uuid", nullable: false),
                    provider = table.Column<string>(type: "text", nullable: true),
                    model = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    prompt = table.Column<string>(type: "text", nullable: true),
                    response = table.Column<string>(type: "text", nullable: true),
                    requested_user_id = table.Column<Guid>(type: "uuid", nullable: true),
                    kind = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ai_run", x => x.id);
                    table.ForeignKey(
                        name: "FK_ai_run_agent_agent_id",
                        column: x => x.agent_id,
                        principalTable: "agent",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ai_run_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ai_run_ticket_ticket_id",
                        column: x => x.ticket_id,
                        principalTable: "ticket",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ai_run_user_requested_user_id",
                        column: x => x.requested_user_id,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "content_artifact",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ticket_id = table.Column<Guid>(type: "uuid", nullable: false),
                    kind = table.Column<string>(type: "text", nullable: true),
                    title = table.Column<string>(type: "text", nullable: true),
                    format = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    version = table.Column<string>(type: "text", nullable: true),
                    meta = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    body = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_content_artifact", x => x.id);
                    table.ForeignKey(
                        name: "FK_content_artifact_client_client_id",
                        column: x => x.client_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_content_artifact_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_content_artifact_ticket_ticket_id",
                        column: x => x.ticket_id,
                        principalTable: "ticket",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket_approval",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ticket_id = table.Column<Guid>(type: "uuid", nullable: false),
                    approver_user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    decision = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket_approval", x => x.id);
                    table.ForeignKey(
                        name: "FK_ticket_approval_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_approval_ticket_ticket_id",
                        column: x => x.ticket_id,
                        principalTable: "ticket",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_approval_user_approver_user_id",
                        column: x => x.approver_user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket_attachment",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ticket_id = table.Column<Guid>(type: "uuid", nullable: false),
                    file_id = table.Column<Guid>(type: "uuid", nullable: false),
                    uploaded_by_user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket_attachment", x => x.id);
                    table.ForeignKey(
                        name: "FK_ticket_attachment_file_entity_file_id",
                        column: x => x.file_id,
                        principalTable: "file_entity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_attachment_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_attachment_ticket_ticket_id",
                        column: x => x.ticket_id,
                        principalTable: "ticket",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_attachment_user_uploaded_by_user_id",
                        column: x => x.uploaded_by_user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket_comment",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ticket_id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    body = table.Column<string>(type: "text", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket_comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_ticket_comment_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_comment_ticket_ticket_id",
                        column: x => x.ticket_id,
                        principalTable: "ticket",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_comment_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "content_media",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    content_artifact_id = table.Column<Guid>(type: "uuid", nullable: false),
                    file_id = table.Column<Guid>(type: "uuid", nullable: false),
                    position = table.Column<int>(type: "integer", nullable: false),
                    alt_text = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_content_media", x => x.id);
                    table.ForeignKey(
                        name: "FK_content_media_content_artifact_content_artifact_id",
                        column: x => x.content_artifact_id,
                        principalTable: "content_artifact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_content_media_file_entity_file_id",
                        column: x => x.file_id,
                        principalTable: "file_entity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_content_media_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "content_publication",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ticket_id = table.Column<Guid>(type: "uuid", nullable: false),
                    content_artifact_id = table.Column<Guid>(type: "uuid", nullable: false),
                    provider_resource_id = table.Column<Guid>(type: "uuid", nullable: true),
                    channel = table.Column<string>(type: "text", nullable: true),
                    timezone = table.Column<string>(type: "text", nullable: true),
                    scheduled_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    posted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    external_id = table.Column<string>(type: "text", nullable: true),
                    permalink = table.Column<string>(type: "text", nullable: true),
                    error_message = table.Column<string>(type: "text", nullable: true),
                    idempotency_key = table.Column<string>(type: "text", nullable: true),
                    last_attempted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    payload_json = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    attempt_count = table.Column<int>(type: "integer", nullable: false),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_content_publication", x => x.id);
                    table.ForeignKey(
                        name: "FK_content_publication_content_artifact_content_artifact_id",
                        column: x => x.content_artifact_id,
                        principalTable: "content_artifact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_content_publication_provider_resource_provider_resource_id",
                        column: x => x.provider_resource_id,
                        principalTable: "provider_resource",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_content_publication_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_content_publication_ticket_ticket_id",
                        column: x => x.ticket_id,
                        principalTable: "ticket",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usage_event",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    stripe_meter_id = table.Column<string>(type: "text", nullable: true),
                    stripe_meter_event_id = table.Column<string>(type: "text", nullable: true),
                    quantity = table.Column<long>(type: "bigint", nullable: false),
                    recorded_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    price_id = table.Column<string>(type: "text", nullable: true),
                    wallet_transaction_id = table.Column<Guid>(type: "uuid", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usage_event", x => x.id);
                    table.ForeignKey(
                        name: "FK_usage_event_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wallet_transaction",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    wallet_id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<Guid>(type: "uuid", nullable: false),
                    direction = table.Column<string>(type: "text", nullable: true),
                    reason_code = table.Column<string>(type: "text", nullable: true),
                    tokens = table.Column<long>(type: "bigint", nullable: false),
                    related_usage_record_id = table.Column<Guid>(type: "uuid", nullable: true),
                    token_pack_id = table.Column<Guid>(type: "uuid", nullable: true),
                    stripe_checkout_session_id = table.Column<string>(type: "text", nullable: true),
                    stripe_payment_intent_id = table.Column<string>(type: "text", nullable: true),
                    stripe_invoice_id = table.Column<string>(type: "text", nullable: true),
                    expires_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    created_by_user_id = table.Column<Guid>(type: "uuid", nullable: true),
                    stripe_credit_grant_id = table.Column<string>(type: "text", nullable: true),
                    row_version = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    created_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_by_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    deleted_by_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wallet_transaction", x => x.id);
                    table.ForeignKey(
                        name: "FK_wallet_transaction_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wallet_transaction_token_pack_token_pack_id",
                        column: x => x.token_pack_id,
                        principalTable: "token_pack",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_wallet_transaction_token_wallet_wallet_id",
                        column: x => x.wallet_id,
                        principalTable: "token_wallet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wallet_transaction_usage_event_related_usage_record_id",
                        column: x => x.related_usage_record_id,
                        principalTable: "usage_event",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_wallet_transaction_user_created_by_user_id",
                        column: x => x.created_by_user_id,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_agent_class_id",
                table: "agent",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_agent_tenant_id",
                table: "agent",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_ai_run_agent_id",
                table: "ai_run",
                column: "agent_id");

            migrationBuilder.CreateIndex(
                name: "IX_ai_run_requested_user_id",
                table: "ai_run",
                column: "requested_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ai_run_tenant_id",
                table: "ai_run",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_ai_run_ticket_id",
                table: "ai_run",
                column: "ticket_id");

            migrationBuilder.CreateIndex(
                name: "IX_auto_topup_settings_default_payment_method_id",
                table: "auto_topup_settings",
                column: "default_payment_method_id");

            migrationBuilder.CreateIndex(
                name: "IX_auto_topup_settings_token_pack_id",
                table: "auto_topup_settings",
                column: "token_pack_id");

            migrationBuilder.CreateIndex(
                name: "IX_auto_topup_settings_wallet_id",
                table: "auto_topup_settings",
                column: "wallet_id");

            migrationBuilder.CreateIndex(
                name: "IX_board_client_id",
                table: "board",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_board_tenant_id",
                table: "board",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_board_column_board_id",
                table: "board_column",
                column: "board_id");

            migrationBuilder.CreateIndex(
                name: "IX_board_column_client_id",
                table: "board_column",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_brand_asset_brand_profile_id",
                table: "brand_asset",
                column: "brand_profile_id");

            migrationBuilder.CreateIndex(
                name: "IX_brand_asset_file_id",
                table: "brand_asset",
                column: "file_id");

            migrationBuilder.CreateIndex(
                name: "IX_brand_asset_tenant_id",
                table: "brand_asset",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_brand_profile_client_id",
                table: "brand_profile",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_brand_profile_tenant_id",
                table: "brand_profile",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_charge_tenant_id",
                table: "charge",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_client_organisation_id",
                table: "client",
                column: "organisation_id");

            migrationBuilder.CreateIndex(
                name: "IX_client_tenant_id",
                table: "client",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_contact_person_organisation_id",
                table: "contact_person",
                column: "organisation_id");

            migrationBuilder.CreateIndex(
                name: "IX_contact_person_tenant_id",
                table: "contact_person",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_artifact_client_id",
                table: "content_artifact",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_artifact_tenant_id",
                table: "content_artifact",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_artifact_ticket_id",
                table: "content_artifact",
                column: "ticket_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_media_content_artifact_id",
                table: "content_media",
                column: "content_artifact_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_media_file_id",
                table: "content_media",
                column: "file_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_media_tenant_id",
                table: "content_media",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_publication_content_artifact_id",
                table: "content_publication",
                column: "content_artifact_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_publication_provider_resource_id",
                table: "content_publication",
                column: "provider_resource_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_publication_tenant_id",
                table: "content_publication",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_content_publication_ticket_id",
                table: "content_publication",
                column: "ticket_id");

            migrationBuilder.CreateIndex(
                name: "IX_file_entity_tenant_id",
                table: "file_entity",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_subscription_id",
                table: "invoice",
                column: "subscription_id");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_tenant_id",
                table: "invoice",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_organisation_tenant_id",
                table: "organisation",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_payment_method_tenant_id",
                table: "payment_method",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_provider_connection_client_id",
                table: "provider_connection",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_provider_connection_integration_definition_id",
                table: "provider_connection",
                column: "integration_definition_id");

            migrationBuilder.CreateIndex(
                name: "IX_provider_connection_tenant_id",
                table: "provider_connection",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_provider_resource_provider_connection_id",
                table: "provider_resource",
                column: "provider_connection_id");

            migrationBuilder.CreateIndex(
                name: "IX_provider_resource_tenant_id",
                table: "provider_resource",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_tenant_id",
                table: "role",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_subscription_default_payment_method_id",
                table: "subscription",
                column: "default_payment_method_id");

            migrationBuilder.CreateIndex(
                name: "IX_subscription_plan_id",
                table: "subscription",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_subscription_tenant_id",
                table: "subscription",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_subscription_item_plan_id",
                table: "subscription_item",
                column: "plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_subscription_item_subscription_id",
                table: "subscription_item",
                column: "subscription_id");

            migrationBuilder.CreateIndex(
                name: "IX_tenant_invite_invited_by_user_id",
                table: "tenant_invite",
                column: "invited_by_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_tenant_invite_tenant_id",
                table: "tenant_invite",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_tenant_membership_role_id",
                table: "tenant_membership",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_tenant_membership_user_id",
                table: "tenant_membership",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_assignee_user_id",
                table: "ticket",
                column: "assignee_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_client_id",
                table: "ticket",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_column_id",
                table: "ticket",
                column: "column_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_owner_user_id",
                table: "ticket",
                column: "owner_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_tenant_id",
                table: "ticket",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_approval_approver_user_id",
                table: "ticket_approval",
                column: "approver_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_approval_tenant_id",
                table: "ticket_approval",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_approval_ticket_id",
                table: "ticket_approval",
                column: "ticket_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_attachment_file_id",
                table: "ticket_attachment",
                column: "file_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_attachment_tenant_id",
                table: "ticket_attachment",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_attachment_ticket_id",
                table: "ticket_attachment",
                column: "ticket_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_attachment_uploaded_by_user_id",
                table: "ticket_attachment",
                column: "uploaded_by_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_comment_tenant_id",
                table: "ticket_comment",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_comment_ticket_id",
                table: "ticket_comment",
                column: "ticket_id");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_comment_user_id",
                table: "ticket_comment",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_token_wallet_tenant_id",
                table: "token_wallet",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_usage_event_tenant_id",
                table: "usage_event",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_usage_event_wallet_transaction_id",
                table: "usage_event",
                column: "wallet_transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_default_tenant_id",
                table: "user",
                column: "default_tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_identity_user_id",
                table: "user_identity",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_organisation_id",
                table: "vendor",
                column: "organisation_id");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_tenant_id",
                table: "vendor",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_wallet_transaction_created_by_user_id",
                table: "wallet_transaction",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_wallet_transaction_related_usage_record_id",
                table: "wallet_transaction",
                column: "related_usage_record_id");

            migrationBuilder.CreateIndex(
                name: "IX_wallet_transaction_tenant_id",
                table: "wallet_transaction",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "IX_wallet_transaction_token_pack_id",
                table: "wallet_transaction",
                column: "token_pack_id");

            migrationBuilder.CreateIndex(
                name: "IX_wallet_transaction_wallet_id",
                table: "wallet_transaction",
                column: "wallet_id");

            migrationBuilder.AddForeignKey(
                name: "FK_usage_event_wallet_transaction_wallet_transaction_id",
                table: "usage_event",
                column: "wallet_transaction_id",
                principalTable: "wallet_transaction",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_token_wallet_tenant_tenant_id",
                table: "token_wallet");

            migrationBuilder.DropForeignKey(
                name: "FK_usage_event_tenant_tenant_id",
                table: "usage_event");

            migrationBuilder.DropForeignKey(
                name: "FK_user_tenant_default_tenant_id",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_wallet_transaction_tenant_tenant_id",
                table: "wallet_transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_wallet_transaction_user_created_by_user_id",
                table: "wallet_transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_wallet_transaction_token_pack_token_pack_id",
                table: "wallet_transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_wallet_transaction_token_wallet_wallet_id",
                table: "wallet_transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_usage_event_wallet_transaction_wallet_transaction_id",
                table: "usage_event");

            migrationBuilder.DropTable(
                name: "ai_run");

            migrationBuilder.DropTable(
                name: "auto_topup_settings");

            migrationBuilder.DropTable(
                name: "brand_asset");

            migrationBuilder.DropTable(
                name: "charge");

            migrationBuilder.DropTable(
                name: "contact_person");

            migrationBuilder.DropTable(
                name: "content_media");

            migrationBuilder.DropTable(
                name: "content_publication");

            migrationBuilder.DropTable(
                name: "invoice");

            migrationBuilder.DropTable(
                name: "role_permission");

            migrationBuilder.DropTable(
                name: "subscription_item");

            migrationBuilder.DropTable(
                name: "tenant_invite");

            migrationBuilder.DropTable(
                name: "tenant_membership");

            migrationBuilder.DropTable(
                name: "ticket_approval");

            migrationBuilder.DropTable(
                name: "ticket_attachment");

            migrationBuilder.DropTable(
                name: "ticket_comment");

            migrationBuilder.DropTable(
                name: "user_identity");

            migrationBuilder.DropTable(
                name: "user_settings");

            migrationBuilder.DropTable(
                name: "vendor");

            migrationBuilder.DropTable(
                name: "agent");

            migrationBuilder.DropTable(
                name: "brand_profile");

            migrationBuilder.DropTable(
                name: "content_artifact");

            migrationBuilder.DropTable(
                name: "provider_resource");

            migrationBuilder.DropTable(
                name: "subscription");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "file_entity");

            migrationBuilder.DropTable(
                name: "agent_class");

            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "provider_connection");

            migrationBuilder.DropTable(
                name: "payment_method");

            migrationBuilder.DropTable(
                name: "plan");

            migrationBuilder.DropTable(
                name: "board_column");

            migrationBuilder.DropTable(
                name: "integration_definition");

            migrationBuilder.DropTable(
                name: "board");

            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "organisation");

            migrationBuilder.DropTable(
                name: "tenant");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "token_pack");

            migrationBuilder.DropTable(
                name: "token_wallet");

            migrationBuilder.DropTable(
                name: "wallet_transaction");

            migrationBuilder.DropTable(
                name: "usage_event");
        }
    }
}
