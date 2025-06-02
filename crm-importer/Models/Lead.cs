using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crm_importer.Models;

[PrimaryKey(nameof(QuoteSentDate), nameof(SalesPerson), nameof(ProjectName))]
public class Lead
{
    [DataType(DataType.DateTime)]
    public required DateTime QuoteSentDate { get; set; }
    public required string SalesPerson { get; set; }
    public required string ProjectName { get; set; }
    public string? raw { get; set; }
}