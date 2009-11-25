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

namespace JelloScrum.Model.Tests.Creations
{
    using Entities;
    using Enumerations;

    public partial class Creation
    {
        public static Sprint Sprint()
        {
            return new Sprint();
        }

        public static Sprint SprintMetScrumMasterEnProductOwner()
        {
            Sprint sprint = Sprint();
            sprint.VoegGebruikerToe(Gebruiker(), SprintRol.ScrumMaster);
            sprint.VoegGebruikerToe(Gebruiker(), SprintRol.ProductOwner);
            return sprint;
        }

        public static Sprint Sprint(Project project)
        {
            return new Sprint(project);
        }
    }
}