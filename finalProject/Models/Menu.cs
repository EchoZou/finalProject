//Name: COMP2007 Enterprise Computing final project  - Summer 2016
//Author: Mo Zou &¡¡Pui in Kwok & Yang Li
//Description: This assignment base on assginment 2, the MVC restaurant. Then add more security control and get motified website. 


namespace finalProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //get and set all details of menu
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        public int MenuID { get; set; }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
