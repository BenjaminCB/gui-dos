namespace gui_dos.Models
{
    ///<summary>Describes the possible statuses an order can have. </summary>
    public enum OrderStatus
    {
        Pending,
        Accepted,
        Assembling,
        Finished,
        Delivered,
        Declined,
        Cancelled
    }
}
