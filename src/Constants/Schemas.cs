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

namespace Dgmjr.EntityFrameworkCore.Constants;

public static partial class Schemas
{
    public const string DboSchema = "dbo";
    public const string InformationSchema = "information_schema";
    public const string MasterSchema = "master";
    public const string MsdbSchema = "msdb";
    public const string SysSchema = "sys";
    public const string TempdbSchema = "tempdb";
    public const string ModelSchema = "model";
    public const string IdSchema = "id";
}

[GenerateEnumerationRecordStruct("DbSchema", "Dgmjr.EntityFrameworkCore")]
public enum SchemasEnum
{
    [Display(Name = "DBO Schema", ShortName = "dbo", Description = "The dbo schema")]
    Dbo,

    [Display(
        Name = "Information Schema",
        ShortName = "information_schema",
        Description = "The information_schema schema"
    )]
    Information,

    [Display(Name = "Master Schema", ShortName = "master", Description = "The master schema")]
    Master,

    [Display(Name = "MSDB Schema", ShortName = "msdb", Description = "The msdb schema")]
    Msdb,

    [Display(Name = "SYS Schema", ShortName = "sys", Description = "The sys schema")]
    Sys,

    [Display(Name = "TEMPDB Schema", ShortName = "tempdb", Description = "The tempdb schema")]
    TempDb,

    [Display(Name = "Model Schema", ShortName = "model", Description = "The model schema")]
    Model,

    [Display(Name = "Identity Schema", ShortName = "id", Description = "The id schema")]
    Identity,
}
