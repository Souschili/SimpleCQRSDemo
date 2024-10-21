using CQRSDemo.Api.Context;
using CQRSDemo.Api.Entities;
using MediatR;

namespace CQRSDemo.Api.Application.Orders.Command.OrderCreate
{
    public class OrderCreateCommandHandler : IRequestHandler<OrderCreateCommand, int>
    {
        private readonly WriteDbContext _dbContext;
        public OrderCreateCommandHandler(WriteDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<int> Handle(OrderCreateCommand request,
            CancellationToken cancellationToken)
        {
            var order = new Order
            {
                CustomerId = request.CustomerId,
                TotalAmount = request.TotalAmount,
                OrderDate = request.OrderDate,
                Status = request.Status
            };
            await _dbContext.AddAsync(order);
            await _dbContext.SaveChangesAsync();

            return order.Id;
        }
    }
}
