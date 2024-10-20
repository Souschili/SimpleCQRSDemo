using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CQRSDemo.Api.Application.Orders.Command.OrderCreate
{
    public record class OrderCreateCommand(int CustomerId,
        DateTime OrderDate,
        decimal TotalAmount,
        string Status) : IRequest<Unit>
    { }

}
