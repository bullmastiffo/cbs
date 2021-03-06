/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Dolittle.Commands.Handling;
using Dolittle.Domain;

namespace Domain.NationalSocieties
{
    public class NationalSocietyCommandHandler : ICanHandleCommands
    {
        readonly IAggregateRootRepositoryFor<NationalSociety>  _aggregateRootRepoForNationalSociety;

        public NationalSocietyCommandHandler(
            IAggregateRootRepositoryFor<NationalSociety>  aggregateRootRepoForNationalSociety            
        )
        {
             _aggregateRootRepoForNationalSociety =  aggregateRootRepoForNationalSociety;
        }

    }
}
