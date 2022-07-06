// See https://aka.ms/new-console-template for more information
namespace Assignment_on_classes
{
    class program
    {
        static void Main(string[] args)
        {
            List<Animals> listquestions = new List<Animals>
            {
                new Animals("Goat","Capra aegagrus","Terrestrial","2 pairs","mammal","A herd or tribe",true),
                new Animals("Frog","Anura","Aquatic","2 pairs","Amphibia","An army",false),
                new Animals("Crocodile","Crocodylidae","Aquatic","2 pairs","Reptile","A bask",false)

            };
            foreach (var ques in listquestions)
            {
                Console.WriteLine(ques.name);
            }




            //Animals animal1 = new Animals();
            //animal1.name = "Goat";
            //animal1.scientific_name = "Capra aegagrus";
            //animal1.habitat = "Terrestrial";
            //animal1.pair_of_limb = "2 pairs";
            //animal1.class_of_animal = "mammal";
            //animal1.collective_name = "A herd or tribe";
            //animal1.regurgitate = true;

            //Animals animal2 = new Animals();
            //animal2.name = "Frog";
            //animal2.scientific_name = "Anura";
            //animal2.habitat = "Aquatic";
            //animal2.pair_of_limb = "2 pairs";
            //animal2.class_of_animal = "Amphibia";
            //animal2.collective_name = "An army";
            //animal2.regurgitate = false;

            //Animals animal3 = new Animals();
            //animal3.name = "Crocodile";
            //animal3.scientific_name = "Crocodylidae";
            //animal3.habitat = "Aquatic";
            //animal3.pair_of_limb = "2 pairs";
            //animal3.class_of_animal = "Reptile";
            //animal3.collective_name = "A bask";
            //animal3.regurgitate = false;

            //Animals animal4 = new Animals();
            //animal4.name = "Rabbit";
            //animal4.scientific_name = "Oryctolagus coniculus";
            //animal4.habitat = "Terrestrial";
            //animal4.pair_of_limb = "2 pairs";
            //animal4.class_of_animal = "mammal";
            //animal4.collective_name = "A herd";
            //animal4.regurgitate = false;

            //Animals animal5 = new Animals();
            //animal5.name = "Eagle";
            //animal5.scientific_name = "Accipitridae";
            //animal5.habitat = "Aborial";
            //animal5.pair_of_limb = "A pair";
            //animal5.class_of_animal = "Aves";
            //animal5.collective_name = "A convocation or congregation";
            //animal5.regurgitate = false;


            //List<object> view = new List<object>();
            //view.Add(animal1.name);
            //view.Add(animal1.scientific_name);
            //view.Add(animal1.habitat);
            //view.Add(animal1.pair_of_limb);
            //view.Add(animal1.class_of_animal);
            //view.Add(animal1.class_of_animal);
            //view.Add(animal1.collective_name);
            //view.Add(animal1.regurgitate);

            //view.Add(animal2.name);
            //view.Add(animal2.scientific_name);
            //view.Add(animal2.habitat);
            //view.Add(animal2.pair_of_limb);
            //view.Add(animal2.class_of_animal);
            //view.Add(animal2.class_of_animal);
            //view.Add(animal2.collective_name);
            //view.Add(animal2.regurgitate);

            //view.Add(animal3.name);
            //view.Add(animal3.scientific_name);
            //view.Add(animal3.habitat);
            //view.Add(animal3.pair_of_limb);
            //view.Add(animal3.class_of_animal);
            //view.Add(animal3.class_of_animal);
            //view.Add(animal3.collective_name);
            //view.Add(animal3.regurgitate);

            //view.Add(animal4.name);
            //view.Add(animal4.scientific_name);
            //view.Add(animal4.habitat);
            //view.Add(animal4.pair_of_limb);
            //view.Add(animal4.class_of_animal);
            //view.Add(animal4.class_of_animal);
            //view.Add(animal4.collective_name);
            //view.Add(animal4.regurgitate);

            //view.Add(animal5.name);
            //view.Add(animal5.scientific_name);
            //view.Add(animal5.habitat);
            //view.Add(animal5.pair_of_limb);
            //view.Add(animal5.class_of_animal);
            //view.Add(animal5.class_of_animal);
            //view.Add(animal5.collective_name);
            //view.Add(animal5.regurgitate);

            //foreach(var animal in view)
            //{
            //    Console.WriteLine(animal);
            //}


        }
        
    }
}
