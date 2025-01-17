//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.Linq;

using Rock.Attribute;
using Rock.Data;
using Rock.ViewModels;
using Rock.ViewModels.Entities;
using Rock.Web.Cache;

namespace Rock.Model
{
    /// <summary>
    /// MetaNickNameLookup Service class
    /// </summary>
    public partial class MetaNickNameLookupService : Service<MetaNickNameLookup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaNickNameLookupService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public MetaNickNameLookupService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( MetaNickNameLookup item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class MetaNickNameLookupExtensionMethods
    {
        /// <summary>
        /// Clones this MetaNickNameLookup object to a new MetaNickNameLookup object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static MetaNickNameLookup Clone( this MetaNickNameLookup source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as MetaNickNameLookup;
            }
            else
            {
                var target = new MetaNickNameLookup();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this MetaNickNameLookup object to a new MetaNickNameLookup object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static MetaNickNameLookup CloneWithoutIdentity( this MetaNickNameLookup source )
        {
            var target = new MetaNickNameLookup();
            target.CopyPropertiesFrom( source );

            target.Id = 0;
            target.Guid = Guid.NewGuid();
            target.ForeignKey = null;
            target.ForeignId = null;
            target.ForeignGuid = null;

            return target;
        }

        /// <summary>
        /// Copies the properties from another MetaNickNameLookup object to this MetaNickNameLookup object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this MetaNickNameLookup target, MetaNickNameLookup source )
        {
            target.Id = source.Id;
            target.Count = source.Count;
            target.FirstName = source.FirstName;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.Gender = source.Gender;
            target.NickName = source.NickName;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }

    }

}
