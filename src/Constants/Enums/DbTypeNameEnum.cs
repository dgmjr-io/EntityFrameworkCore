namespace Dgmjr.EntityFrameworkCore.Enums;

[GenerateEnumerationRecordStruct("DbTypeName", "Dgmjr.EntityFrameworkCore")]
public enum DbTypeName
{
    [Display(Name = "bigint")]
    DbTypeBigInt,
    [Display(Name = "int")]
    DbTypeInt,
    [Display(Name = "byte")]
    DbTypeByte,
    [Display(Name = "varchar")]
    DbTypeVarChar,
    [Display(Name = "nvarchar")]
    DbTypeNVarChar,
    [Display(Name = "nchar")]
    DbTypeNChar,
    [Display(Name = "char")]
    DbTypeChar,
    [Display(Name = "tinyint")]
    DbTypeTinyInt,
    [Display(Name = "rowversion")]
    DbTypeRowVersion,
    [Display(Name = "datetime")]
    DbTypeDateTime
}
