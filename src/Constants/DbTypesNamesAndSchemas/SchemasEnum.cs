/*
 * Schemas.cs
 *
 *   Created: 2022-12-01-05:21:45
 *   Modified: 2022-12-01-05:21:46
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Enums;

[GenerateEnumerationRecordStruct("DbSchemas", "Dgmjr.EntityFrameworkCore")]
public enum SchemasEnum
{
    [Display(Name = "DBO Schema", ShortName = "dbo", Description = "The dbo schema")]
    DboSchema,

    [Display(Name = "Guest Schema", ShortName = "guest", Description = "The guest schema")]
    GuestSchema,

    [Display(
        Name = "Information Schema",
        ShortName = "information_schema",
        Description = "The information_schema schema"
    )]
    InformationSchema,

    [Display(Name = "Master Schema", ShortName = "master", Description = "The master schema")]
    MasterSchema,

    [Display(Name = "MSDB Schema", ShortName = "msdb", Description = "The msdb schema")]
    MsdbSchema,

    [Display(Name = "SYS Schema", ShortName = "sys", Description = "The sys schema")]
    SysSchema,

    [Display(Name = "TEMPDB Schema", ShortName = "tempdb", Description = "The tempdb schema")]
    TempDbSchema,

    [Display(Name = "Model Schema", ShortName = "model", Description = "The model schema")]
    ModelSchema,

    [Display(Name = "Identity Schema", ShortName = "id", Description = "The id schema")]
    IdentitySchema,

    [Display(Name = "Data Schema", ShortName = "data", Description = "The data schema")]
    DataSchema,

    [Display(
        Name = "Security Admin Schema",
        ShortName = "db_securityadmin",
        Description = "The db_securityadmin schema"
    )]
    DbSecurityAdminSchema,

    [Display(
        Name = "Access Admin Schema",
        ShortName = "db_accessadmin",
        Description = "The db_accessadmin schema"
    )]
    DbAccessAdminSchema,

    [Display(
        Name = "Backup Operator Schema",
        ShortName = "db_backupoperator",
        Description = "The db_backupoperator schema"
    )]
    DbBackupOperatorSchema,

    [Display(
        Name = "Data Reader Schema",
        ShortName = "db_datareader",
        Description = "The db_datareader schema"
    )]
    DbDataReaderSchema,

    [Display(
        Name = "Data Writer Schema",
        ShortName = "db_datawriter",
        Description = "The db_datawriter schema"
    )]
    DbDataWriterSchema,

    [Display(Name = "DB Owner Schema", ShortName = "db_owner", Description = "The db_owner schema")]
    DbOwnerSchema,

    [Display(
        Name = "DDL Admin Schema",
        ShortName = "db_ddladmin",
        Description = "The db_ddladmin schema"
    )]
    DbDdlAdminSchema
}
