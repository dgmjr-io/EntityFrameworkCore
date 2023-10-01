namespace Dgmjr.EntityFrameworkCore.Enums;

/// <summary>Enum representing database type names, with each enum value having a corresponding string value represented by the Display attribute.</summary>
[GenerateEnumerationRecordStruct("DbTypeName", "Dgmjr.EntityFrameworkCore")]
public enum DbTypeName
{
    /// <summary> Database type of bigint.</summary>
    [Display(Name = "bigint", Description = " Database type of bigint.", ShortName = "bigint")]
    DbTypeBigInt,

    /// <summary> Database type of int.</summary>
    [Display(Name = "int", Description = " Database type of int.", ShortName = "int")]
    DbTypeInt,

    /// <summary> Database type of byte.</summary>
    [Display(Name = "byte", Description = " Database type of byte.", ShortName = "byte")]
    DbTypeByte,

    /// <summary> Database type of varchar.</summary>
    [Display(Name = "varchar", Description = " Database type of varchar.", ShortName = "varchar")]
    DbTypeVarChar,

    /// <summary> Database type of nvarchar.</summary>
    [Display(
        Name = "nvarchar",
        Description = " Database type of nvarchar.",
        ShortName = "nvarchar"
    )]
    DbTypeNVarChar,

    /// <summary> Database type of nchar.</summary>
    [Display(Name = "nchar", Description = " Database type of nchar.", ShortName = "nchar")]
    DbTypeNChar,

    /// <summary> Database type of char.</summary>
    [Display(Name = "char", Description = " Database type of char.", ShortName = "char")]
    DbTypeChar,

    /// <summary> Database type of tinyint.</summary>
    [Display(Name = "tinyint", Description = " Database type of tinyint.", ShortName = "tinyint")]
    DbTypeTinyInt,

    /// <summary> Database row version type.</summary>
    [Display(
        Name = "rowversion",
        Description = " Database row version type.",
        ShortName = "rowversion"
    )]
    DbTypeRowVersion,

    /// <summary> Database type of datetime.</summary>
    [Display(
        Name = "datetime",
        Description = " Database type of datetime.",
        ShortName = "datetime"
    )]
    DbTypeDateTime,

    /// <summary> Database type of varbinary.</summary>
    [Display(
        Name = "varbinary",
        Description = " Database type of varbinary.",
        ShortName = "varbinary"
    )]
    DbTypeVarBinary
}
