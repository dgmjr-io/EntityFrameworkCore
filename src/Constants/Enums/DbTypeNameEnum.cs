namespace Dgmjr.EntityFrameworkCore.Enums;

/// <summary>Enum representing database type names, with each enum value having a corresponding string value represented by the Display attribute.</summary>
[GenerateEnumerationRecordStruct("DbTypes", "Dgmjr.EntityFrameworkCore")]
public enum DbType
{
    /// <summary>Database type of bigint.</summary>
    [Display(Name = "bigint", Description = "Database type of bigint.", ShortName = "bigint")]
    DbTypeBigInt,

    /// <summary>Database type of int.</summary>
    [Display(Name = "int", Description = "Database type of int.", ShortName = "int")]
    DbTypeInt,

    /// <summary>Database type of byte.</summary>
    [Display(Name = "byte", Description = "Database type of byte.", ShortName = "byte")]
    DbTypeByte,

    /// <summary>Database type of varchar.</summary>
    [Display(Name = "varchar", Description = "Database type of varchar.", ShortName = "varchar")]
    DbTypeVarChar,

    /// <summary>Database type of varchar(MAX).</summary>
    [Display(
        Name = "varchar(MAX)",
        Description = "Database type of varchar(MAX).",
        ShortName = "varchar(MAX)"
    )]
    DbTypeVarCharMax,

    /// <summary>Database type of nvarchar.</summary>
    [Display(Name = "nvarchar", Description = "Database type of nvarchar.", ShortName = "nvarchar")]
    DbTypeNVarChar,

    /// <summary>Database type of nvarchar(MAX).</summary>
    [Display(
        Name = "nvarchar(MAX)",
        Description = "Database type of nvarchar(MAX).",
        ShortName = "nvarchar(MAX)"
    )]
    DbTypeNVarCharMax,

    /// <summary>Database type of nchar.</summary>
    [Display(Name = "nchar", Description = "Database type of nchar.", ShortName = "nchar")]
    DbTypeNChar,

    /// <summary>Database type of nchar(X).</summary>
    [Display(
        Name = "nchar({0})",
        Description = "Database type of nchar(X).",
        ShortName = "nchar({0})"
    )]
    DbTypeNCharX,

    /// <summary>Database type of char.</summary>
    [Display(Name = "char", Description = "Database type of char.", ShortName = "char")]
    DbTypeChar,

    /// <summary>Database type of char(X).</summary>
    [Display(
        Name = "char({0})",
        Description = "Database type of char(X).",
        ShortName = "char({0})"
    )]
    DbTypeCharX,

    /// <summary>Database type of tinyint.</summary>
    [Display(Name = "tinyint", Description = "Database type of tinyint.", ShortName = "tinyint")]
    DbTypeTinyInt,

    /// <summary>Database row version type.</summary>
    [Display(
        Name = "rowversion",
        Description = "Database row version type.",
        ShortName = "rowversion"
    )]
    DbTypeRowVersion,

    /// <summary>Database type of datetime.</summary>
    [Display(Name = "datetime", Description = "Database type of datetime.", ShortName = "datetime")]
    DbTypeDateTime,

    /// <summary>Database type of date.</summary>
    [Display(Name = "date", Description = "Database type of date.", ShortName = "date")]
    DbTypeDate,

    /// <summary>Database type of time.</summary>
    [Display(Name = "time", Description = "Database type of time.", ShortName = "time")]
    DbTypeTime,

    /// <summary>Database type of datetime.</summary>
    [Display(
        Name = "datetimeoffset",
        Description = "Database type of datetimeoffset.",
        ShortName = "datetimeoffset"
    )]
    DbTypeDateTimeOffset,

    /// <summary>Database type of varbinary.</summary>
    [Display(
        Name = "varbinary",
        Description = "Database type of varbinary.",
        ShortName = "varbinary"
    )]
    DbTypeVarBinary,

    /// <summary>Database type of varbinary.</summary>
    [Display(
        Name = "varbinary(MAX)",
        Description = "Database type of varbinary(MAX).",
        ShortName = "varbinary(MAX)"
    )]
    DbTypeVarBinaryMax,

    /// <summary>Database type of varbinary.</summary>
    [Display(Name = "bit", Description = "Database type of bit.", ShortName = "bit")]
    DbTypeBit,

    /// <summary>Database type of varbinary.</summary>
    [Display(Name = "uniqueidentifier", Description = "Database type of uniqueidentifier.", ShortName = "uniqueidentifier")]
    UniqueIdentifier
}
