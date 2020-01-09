﻿using OmniCore.Model.Interfaces.Common;
using OmniCore.Model.Interfaces.Common.Data;
using OmniCore.Model.Interfaces.Common.Data.Entities;
using OmniCore.Model.Interfaces.Common.Data.Repositories;
using OmniCore.Repository.Sqlite.Entities;
using OmniCore.Repository.Sqlite.Repositories;

namespace OmniCore.Repository.Sqlite
{
    public static class Initializer
    {
        public static ICoreContainer<IServerResolvable> WithSqliteRepositories
            (this ICoreContainer<IServerResolvable> container)
        {
            return container
                .Many<IPodRepository, PodRepository>()
                .Many<IMedicationRepository, MedicationRepository>()
                .Many<IRadioEventRepository, RadioEventRepository>()
                .Many<IRadioRepository, RadioRepository>()
                .Many<ISignalStrengthRepository, SignalStrengthRepository>()
                .Many<IUserRepository, UserRepository>()
                .Many<IMigrationHistoryRepository, MigrationHistoryRepository>()
                .Many<IRepositoryMigrator, RepositoryMigrator>()
                .One<IRepositoryService, RepositoryServiceBase>();
        }
    }
}
