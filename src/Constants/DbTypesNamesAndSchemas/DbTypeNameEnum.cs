namespace Dgmjr.EntityFrameworkCore.Enums;

/// <summary>Enum representing database type names, with each enum value having a corresponding string value represented by the Display attribute.</summary>
[GenerateEnumerationRecordStruct("DbTypeNames", "Dgmjr.EntityFrameworkCore")]
public enum DbTypeNames
{
    /// <summary>Database type of bigint.</summary>
    [Display(Name = "bigint", Description = "Database type of bigint.", ShortName = "bigint")]
    BigInt,

    /// <summary>Database type of int.</summary>
    [Display(Name = "int", Description = "Database type of int.", ShortName = "int")]
    Int,

    /// <summary>Database type of byte.</summary>
    [Display(Name = "byte", Description = "Database type of byte.", ShortName = "byte")]
    Byte,

    /// <summary>Database type of varchar.</summary>
    [Display(Name = "varchar", Description = "Database type of varchar.", ShortName = "varchar")]
    VarChar,

    /// <summary>Database type of varchar(MAX).</summary>
    [Display(
        Name = "varchar(MAX)",
        Description = "Database type of varchar(MAX).",
        ShortName = "varchar(MAX)"
    )]
    VarCharMax,

    /// <summary>Database type of nvarchar.</summary>
    [Display(Name = "nvarchar", Description = "Database type of nvarchar.", ShortName = "nvarchar")]
    NVarChar,

    /// <summary>Database type of nvarchar(MAX).</summary>
    [Display(
        Name = "nvarchar(MAX)",
        Description = "Database type of nvarchar(MAX).",
        ShortName = "nvarchar(MAX)"
    )]
    NVarCharMax,

    /// <summary>Database type of nchar.</summary>
    [Display(Name = "nchar", Description = "Database type of nchar.", ShortName = "nchar")]
    NChar,

    /// <summary>Database type of nchar(X).</summary>
    [Display(
        Name = "nchar({0})",
        Description = "Database type of nchar(X).",
        ShortName = "nchar({0})"
    )]
    NCharX,

    /// <summary>Database type of char.</summary>
    [Display(Name = "char", Description = "Database type of char.", ShortName = "char")]
    Char,

    /// <summary>Database type of char(X).</summary>
    [Display(
        Name = "char({0})",
        Description = "Database type of char(X).",
        ShortName = "char({0})"
    )]
    CharX,

    /// <summary>Database type of tinyint.</summary>
    [Display(Name = "tinyint", Description = "Database type of tinyint.", ShortName = "tinyint")]
    TinyInt,

    /// <summary>Database row version type.</summary>
    [Display(
        Name = "rowversion",
        Description = "Database row version type.",
        ShortName = "rowversion"
    )]
    RowVersion,

    /// <summary>Database type of datetime.</summary>
    [Display(Name = "datetime", Description = "Database type of datetime.", ShortName = "datetime")]
    SqlDateTime,
    /// <summary>Database type of datetime2.</summary>
    [Display(Name = "datetime2", Description = "Database type of datetime2.", ShortName = "datetime")]
    SqlDateTime2,

    /// <summary>Database type of date.</summary>
    [Display(Name = "date", Description = "Database type of date.", ShortName = "date")]
    Date,

    /// <summary>Database type of time.</summary>
    [Display(Name = "time", Description = "Database type of time.", ShortName = "time")]
    Time,

    /// <summary>Database type of datetime.</summary>
    [Display(
        Name = "datetimeoffset",
        Description = "Database type of datetimeoffset.",
        ShortName = "datetimeoffset"
    )]
    SqlDateTimeOffset,

    /// <summary>Database type of varbinary.</summary>
    [Display(
        Name = "varbinary",
        Description = "Database type of varbinary.",
        ShortName = "varbinary"
    )]
    VarBinary,

    /// <summary>Database type of varbinary.</summary>
    [Display(
        Name = "varbinary(MAX)",
        Description = "Database type of varbinary(MAX).",
        ShortName = "varbinary(MAX)"
    )]
    VarBinaryMax,

    /// <summary>Database type of varbinary.</summary>
    [Display(Name = "bit", Description = "Database type of bit.", ShortName = "bit")]
    Bit,

    /// <summary>Database type of varbinary.</summary>
    [Display(
        Name = "uniqueidentifier",
        Description = "Database type of uniqueidentifier.",
        ShortName = "uniqueidentifier"
    )]
    UniqueIdentifier,

    /// <summary>Database type of float.</summary>
    [Display(
        Name = "float",
        Description = "Database type of float.",
        ShortName = "float"
    )]
    Float,
    /// <summary>Database type of GEOMETRY.</summary>
    [Display(
        Name = "GEOMETRY",
        Description = "Database type of GEOMETRY.",
        ShortName = "GEOMETRY"
    )]
    Geometry,
    /// <summary>Database type of GEOGRAPHY.</summary>
    [Display(
        Name = "GEOGRAPHY",
        Description = "Database type of GEOGRAPHY.",
        ShortName = "GEOGRAPHY"
    )]
    Geography,
    /// <summary>Database type of VARCHAR({0}).</summary>
    [Display(
        Name = "VARCHAR({0})",
        Description = "Database type of VARCHAR({0}).",
        ShortName = "VARCHAR({0})"
    )]
    VarCharX,
    /// <summary>Database type of NVARCHAR({0}).</summary>
    [Display(
        Name = "NVARCHAR({0})",
        Description = "Database type of NVARCHAR({0}).",
        ShortName = "NVARCHAR({0})"
    )]
    NVarCharX,
}
