// Copyright 2009 Auxilium B.V. - http://www.auxilium.nl/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace JelloScrum.Repositories.Tests.Creations
{
    using Container;
    using JelloScrum.Model.Entities;
    using JelloScrum.Model.Enumerations;
    using JelloScrum.Model.IRepositories;

    /// <summary>
    /// Methodes om allerhande entititeiten aan te maken. Gemaakte objecten worden ook gepersisteerd.
    /// </summary>
    public partial class Creation
    {
        private static IGebruikerRepository gebruikerRepository = IoC.Resolve<IGebruikerRepository>();
        
        private static Gebruiker Persist(Gebruiker gebruiker)
        {
            return gebruikerRepository.Save(gebruiker);
        }

        public static Gebruiker Gebruiker()
        {
            return Persist(new Gebruiker());
        }

        public static Gebruiker Gebruiker(string gebruikersNaam)
        {
            return Persist(new Gebruiker(gebruikersNaam));
        }

        public static Gebruiker Gebruiker(string gebruikersNaam, SysteemRol systeemRol)
        {
            return Persist(new Gebruiker(gebruikersNaam, systeemRol));
        }

    }
}