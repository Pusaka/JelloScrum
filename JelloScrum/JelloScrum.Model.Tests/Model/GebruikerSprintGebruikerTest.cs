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

namespace JelloScrum.Model.Tests.Model
{
    using Entities;
    using Enumerations;
    using NUnit.Framework;

    [TestFixture]
    public class GebruikerSprintGebruikerTest : TestBase
    {
        private Sprint sprint;
        public override void SetUp()
        {
            sprint = new Sprint();
            base.SetUp();
        }

        [Test]
        public void TestVindSprintGebruikerVanGebruikerVoorSprint()
        {
            Gebruiker gb = new Gebruiker();
            sprint.VoegGebruikerToe(gb, SprintRol.Developer);

            SprintGebruiker sg = gb.GeefSprintGebruikerVoor(sprint);

            Assert.AreEqual(gb, sg.Gebruiker);
        }

        [Test]
        public void TestVindGeenSprintGebruikerVanAndereSprints()
        {
            Gebruiker gb = new Gebruiker();
            Sprint sprint2 = new Sprint();
            sprint2.VoegGebruikerToe(gb, SprintRol.Developer);
            sprint.VoegGebruikerToe(gb, SprintRol.Developer);

            SprintGebruiker sg = gb.GeefSprintGebruikerVoor(sprint);

            Assert.AreEqual(sprint, sg.Sprint);
        }

        [Test]
        public void TestGeefActieveSprintGebruikerVanGebruiker()
        {
            Gebruiker gb = new Gebruiker();
            gb.ActieveSprint = sprint;
            sprint.VoegGebruikerToe(gb, SprintRol.Developer);

            SprintGebruiker sg = gb.GeefActieveSprintGebruiker();

            Assert.AreEqual(sg.Gebruiker, gb);
        }

        [Test]
        public void TestGeefActieveSprintGebruikerVanGebruikerTerwijlDezeNogNietGezetIs()
        {
            Gebruiker gb = new Gebruiker();
            sprint.VoegGebruikerToe(gb, SprintRol.Developer);

            SprintGebruiker sg = gb.GeefActieveSprintGebruiker();

            Assert.AreEqual(null, sg);
        }
    }
}