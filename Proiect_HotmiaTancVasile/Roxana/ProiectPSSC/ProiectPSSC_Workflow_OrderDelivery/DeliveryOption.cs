using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_LivrareComanda
{
    internal class DeliveryOption
    {
        [AsChoice]
        public static partial class Delivery
        {
            public interface IDelivery { }
            public record Courier() : IDelivery
            {
                private string courier { get; }
                public Courier(string up) : this()
                {
                    this.courier = courier;
                }
                public string GetQ()
                {
                    return courier.ToString();
                }
            }
            public record Post() : IDelivery
            {
                private string post { get; }
                public Post(double unit) : this()
                {
                    this.post = post;
                }
                public string GetQ()
                {
                    return post.ToString();
                }
            }

            public record OfficeLift() : IDelivery
            {
                private string officeLift { get; }
                public OfficeLift(double unit) : this()
                {
                    this.officeLift = officeLift;
                }
                public string GetQ()
                {
                    return officeLift.ToString();
                }
            }
        }
    }
}
