using System.ComponentModel;

namespace AUA.ProjectName.DomainEntities.Entities.Transportation.TransportationAggregate;

public enum ETransportType
{
    [Description("Regular")]
    Regular = 1,

    [Description("Express")]
    Express = 2
}