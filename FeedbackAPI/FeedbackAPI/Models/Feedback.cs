using System;
using System.Collections.Generic;

namespace FeedbackAPI.Models;

public partial class Feedback
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string PageUrl { get; set; } = null!;

    public string PageName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string FeedbackMessage { get; set; } = null!;

    public decimal Rating { get; set; }

    public int CategoryId { get; set; }

    public string ProjectName { get; set; } = null!;

    public string Image { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
}
