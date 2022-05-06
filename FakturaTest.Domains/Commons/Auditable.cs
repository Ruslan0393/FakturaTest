using FakturaTest.Domains.Enums;
using System;

namespace FakturaTest.Domains.Commons
{
    public abstract class Auditable
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public CarState State { get; set; }

        public void Create()
        {
            this.CreatedAt = DateTime.Now;
            this.State = CarState.Created;
        }


        public void Update()
        {
            this.UpdatedAt = DateTime.Now;
            this.State = CarState.Updated;
        }

    }
}
