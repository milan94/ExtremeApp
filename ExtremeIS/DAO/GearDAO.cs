using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.DAO
{
    class GearDAO
    {
        
        public static List<manufacturer> getAllManufacturers()
        {
            using (var db = new ExtremeAppContext())
            {
                var manufacturers = (from m in db.manufacturers select m).ToList();
                return manufacturers;
            }
        }

        public static List<gear_category> getAllCategories()
        {
            using (var db = new ExtremeAppContext())
            {
                var gearCategory = (from gc in db.gear_category select gc).ToList();
                return gearCategory;
            }
        }

        public static List<gear_size> getAllSizes()
        {
            using (var db = new ExtremeAppContext())
            {
                var gearSizes = (from gs in db.gear_size select gs).ToList();
                return gearSizes;
            }
        }

        public static int insert(gear newGear)                          
        {
            using (var db = new ExtremeAppContext())
            {
                db.gears.Add(newGear);
                db.SaveChanges();
            }
            return newGear.gear_id;
        }


        public static int insertGearSizeItem(gear_size_items newGearSizeItem)
        {
            using (var db = new ExtremeAppContext())
            {
                db.gear_size_items.Add(newGearSizeItem);
                db.SaveChanges();
            }
            return newGearSizeItem.gear_id;
        }



        public static Boolean updateGearSizeItem(gear_size_items gearSizeItemUpdated)
        {
            var result = false;
            using (var db = new ExtremeAppContext())
            {
                var oldGearSizeItem =
                                    (from gsi in db.gear_size_items
                                     where gsi.gear_id == gearSizeItemUpdated.gear_id
                                     where gsi.gear_size_id ==  gearSizeItemUpdated.gear_size_id
                                     select gsi).SingleOrDefault();
                if (oldGearSizeItem != null)
                {
                    oldGearSizeItem.quantity = gearSizeItemUpdated.quantity;
                    oldGearSizeItem.available = gearSizeItemUpdated.quantity;
                    db.SaveChanges();
                    result = true;
                }
            }
            return result;  
        }



        public static List<gear_size_items> getAllSizesByGearId(int id)
        {
            using (var db = new ExtremeAppContext())
            {
                var sizes =
                    (from gsi in db.gear_size_items
                     where gsi.gear_id == id
                     select gsi).ToList();
                return sizes;
            }
        }
        
        public static List<gear_detailed> getAllDetailed()
        {
            using (var db = new ExtremeAppContext())
            {
                var gear =
                    (from g in db.gears
                     join gc in db.gear_category on g.gear_category_id equals gc.gear_category_id
                     join m in db.manufacturers on g.manufacturer_id equals m.manufacturer_id
                     join gsi in db.gear_size_items on g.gear_id equals gsi.gear_id
                     join gs in db.gear_size on gsi.gear_size_id equals gs.gear_size_id
                     select new gear_detailed()
                     {
                         gear_id = g.gear_id,
                         name = g.name,
                         gear_category_id = g.gear_category_id,
                         gear_category_name = gc.name,
                         manufacturer_id = g.manufacturer_id,
                         manufacturer_name = m.name,
                         description = g.descritption,
                         size_id = gs.gear_size_id,
                         size_value = gs.value,
                         quantity = gsi.quantity,
                         available = gsi.available                         
                     }).ToList();

                return gear;
            }
        }
    }
}
