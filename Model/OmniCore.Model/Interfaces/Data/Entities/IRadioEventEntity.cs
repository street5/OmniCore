﻿namespace OmniCore.Model.Interfaces.Common.Data.Entities
{
    public interface IRadioEventEntity : IRadioEventAttributes, IEntity
    {
        IRadioEntity Radio { get; set; }
        IPodEntity Pod { get; set; }
        IPodRequestEntity Request { get; set; }
    }
}
