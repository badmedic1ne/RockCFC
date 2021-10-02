﻿// <copyright>
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
//

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Runtime.Serialization;
using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Represents a connection status automation
    /// </summary>
    [RockDomain( "Engagement" )]
    [Table( "ConnectionStatusAutomation" )]
    [DataContract]
    public partial class ConnectionStatusAutomation : Model<ConnectionStatusAutomation>
    {
        #region Entity Properties

        /// <summary>
        /// Gets or sets the automation name.
        /// </summary>
        /// <value>
        /// The automation name.
        /// </value>
        [Required]
        [MaxLength( 50 )]
        [DataMember( IsRequired = true )]
        public string AutomationName { get; set; }

        /// <summary>
        /// Gets or sets the source <see cref="Rock.Model.ConnectionStatus"/> identifier.
        /// </summary>
        /// <value>
        /// The source connection status identifier.
        /// </value>
        [Required]
        [DataMember]
        public int SourceStatusId { get; set; }

        /// <summary>
        /// Gets or sets the destination <see cref="Rock.Model.ConnectionStatus"/> identifier.
        /// </summary>
        /// <value>
        /// The destination connection status identifier.
        /// </value>
        [Required]
        [DataMember]
        public int DestinationStatusId { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Rock.Model.DataView"/> identifier.
        /// </summary>
        /// <value>
        /// The data view identifier.
        /// </value>
        [DataMember]
        public int? DataViewId { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the <see cref="Rock.Model.ConnectionStatus"/>.
        /// </summary>
        /// <value>
        /// The connection status.
        /// </value>
        [DataMember]
        public virtual ConnectionStatus SourceStatus { get; set; }

        /// <summary>
        /// Gets or sets the destination <see cref="Rock.Model.ConnectionStatus"/>.
        /// </summary>
        /// <value>
        /// The destination connection status.
        /// </value>
        [DataMember]
        public virtual ConnectionStatus DestinationStatus { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Rock.Model.DataView"/>.
        /// </summary>
        /// <value>
        /// The data view.
        /// </value>
        [DataMember]
        public virtual DataView DataView { get; set; }

        #endregion

        #region overrides

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.AutomationName;
        }

        #endregion
    }

    #region Entity Configuration

    /// <summary>
    /// Connection Status Automation Configuration class.
    /// </summary>
    public partial class ConnectionStatusAutomationConfiguration : EntityTypeConfiguration<ConnectionStatusAutomation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionStatusAutomationConfiguration" /> class.
        /// </summary>
        public ConnectionStatusAutomationConfiguration()
        {
            this.HasRequired( p => p.SourceStatus ).WithMany( p => p.ConnectionStatusAutomations ).HasForeignKey( p => p.SourceStatusId ).WillCascadeOnDelete( false );
            this.HasRequired( p => p.DestinationStatus ).WithMany().HasForeignKey( p => p.DestinationStatusId ).WillCascadeOnDelete( false );
            this.HasOptional( p => p.DataView ).WithMany().HasForeignKey( p => p.DataViewId ).WillCascadeOnDelete( false );
        }
    }

    #endregion
}