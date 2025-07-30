namespace Questions.Domain.Reports;

public enum ReportStatus
{
    /// <summary>
    /// Жалоба открыта
    /// </summary>
    Open,

    /// <summary>
    /// Жалоба на рассмотрении
    /// </summary>
    InProgress,

    /// <summary>
    /// Жалоба успешно закрыта
    /// </summary>
    Resolved,

    /// <summary>
    /// Жалоба отменена
    /// </summary>
    Dismissed,
}
