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

namespace JelloScrum.QueryObjects
{
    using Model.Entities;
    using Model.Enumerations;
    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Geeft alle niet opgepakte taken.
    ///  - Specifieer een sprint voor alle niet opgepakte taken in een bepaalde sprint.
    /// </summary>
    public class NietOpgepakteTakenQuery
    {
        public Sprint sprint;

        public ICriteria GetQuery(ISession session)
        {
            ICriteria criteria = session.CreateCriteria(typeof(Task)).Add(Restrictions.Eq("Status", Status.NietOpgepakt));
            
            if (sprint != null)
                criteria.CreateCriteria("Story").CreateCriteria("SprintStories").Add(Restrictions.Eq("Sprint", sprint));

            //criteria.CreateCriteria("LogBerichten");

            return criteria;
        }
    }
}