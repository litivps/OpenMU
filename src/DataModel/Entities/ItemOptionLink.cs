﻿// <copyright file="ItemOptionLink.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.DataModel.Entities
{
    using MUnique.OpenMU.DataModel.Configuration.Items;

    /// <summary>
    /// This class defines a link between the item and the conrete item option which the actual item instance possess.
    /// </summary>
    public class ItemOptionLink
    {
        /// <summary>
        /// Gets or sets the item option.
        /// </summary>
        public virtual IncreasableItemOption ItemOption { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        public int Level { get; set; } = 1;

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>The cloned instance.</returns>
        public virtual ItemOptionLink Clone()
        {
            var link = new ItemOptionLink();
            link.AssignValues(this);
            return link;
        }

        /// <summary>
        /// Assigns the values.
        /// </summary>
        /// <param name="otherLink">The other link.</param>
        public void AssignValues(ItemOptionLink otherLink)
        {
            this.ItemOption = otherLink.ItemOption;
            this.Level = otherLink.Level;
        }
    }
}
