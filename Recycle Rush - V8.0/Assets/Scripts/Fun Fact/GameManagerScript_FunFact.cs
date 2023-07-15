using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript_FunFact : MonoBehaviour
{
    public GameObject[] spawnables;
    public DespawnerScript_FunFact despawnerScript;
    public Text funFactText;    

    // Start is called before the first frame update
    public void Start()
    {
        activateSloMo();
        Application.targetFrameRate = 120;
        DisplayFunFact();
        InvokeRepeating("SpawnObject", 0, 0.06f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject() 
    {
        int chance = Random.Range(-1,90);
        float height = Random.Range(10,12);
        float tempPos = Random.Range(-1.9f, +1.9f);
        int randomRot = Random.Range(-200, 200);
        
        if (chance >= 0 && chance <= 21) { // plastic
            
            if (chance >= 0 && chance <= 10) 
            {
                Instantiate(spawnables[0], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }

            if (chance > 10 && chance <= 21) 
            {
                Instantiate(spawnables[1], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }      
        }

        if (chance > 21 && chance <= 42) { // paper
            
            if (chance > 21 && chance <= 31) 
            {
                Instantiate(spawnables[2], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }

            if (chance > 31 && chance <= 42) 
            {
                Instantiate(spawnables[3], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }
        }
        
        if (chance > 42 && chance <= 63) { // metal
            
            if (chance > 42 && chance <= 53) 
            {
                Instantiate(spawnables[4], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }

            if (chance > 53 && chance <= 63) 
            {
                Instantiate(spawnables[5], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }
        }

        if (chance > 63 && chance <= 84) { // glass
            
            if (chance > 63 && chance <= 73) 
            {
                Instantiate(spawnables[6], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }

            if (chance > 73 && chance <= 84) 
            {
                Instantiate(spawnables[7], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }
        }

        if (chance > 84 && chance <= 90) { // glass
        
            if (chance > 84 && chance <= 90) 
            {
                Instantiate(spawnables[8], new Vector3(tempPos, height, 0), Quaternion.Euler(0,0,randomRot));
            }
        }

    }

    public void DisplayFunFact() 
    {
        
       int factnumber = Random.Range(-1,51); 

       switch(factnumber) 
       {
            case 0: funFactText.text = "Recycling one ton of paper saves around 17 trees, 7,000 gallons of water, and 380 gallons of oil."; break;  
            case 1: funFactText.text = "Aluminum cans can be recycled and turned into new cans in as little as 60 days."; break;   
            case 2: funFactText.text = "Glass can be recycled indefinitely without losing its quality or purity."; break;   
            case 3: funFactText.text = "Recycling plastic can save up to 90% of the energy required to make new plastic from raw materials."; break;   
            case 4: funFactText.text = "Recycling one ton of plastic saves approximately 3.8 barrels of oil."; break;   
            case 5: funFactText.text = "The average American uses about 2,000 pounds of paper products each year, which is equivalent to consuming approximately 6 trees."; break;   
            case 6: funFactText.text = "Electronic waste, or e-waste, contains valuable materials such as gold, silver, and copper that can be recovered through recycling.,"; break;   
            case 7: funFactText.text = "Recycling one aluminum can saves enough energy to run a television for three hours."; break;   
            case 8: funFactText.text = "It takes approximately 75% less energy to produce recycled steel than to produce steel from raw materials."; break; 
            case 9: funFactText.text = "The world produces around 300 million tons of plastic waste every year, but only about 9% of it is recycled."; break;
            
            case 10: funFactText.text = "By recycling one glass bottle, you can save enough energy to power a 100-watt light bulb for four hours."; break;  
            case 11: funFactText.text = "In the United States, approximately 75% of waste is recyclable, but only about 30% actually gets recycled."; break;   
            case 12: funFactText.text = "The recycling symbol, often known as the \"chasing arrows,\" was created in 1970 by Gary Anderson, a 23-year-old college student, as part of a design contest."; break;   
            case 13: funFactText.text = "In some cases, recycling can help create job opportunities. For example, recycling 10,000 tons of waste creates 36 jobs, while landfilling the same amount creates only 6 jobs."; break;   
            case 14: funFactText.text = "The first aluminum can recycling plant was established in 1968."; break;   
            case 15: funFactText.text = "The most recycled consumer product in the world is the automobile. Surprising right?"; break;   
            case 16: funFactText.text = "Recycling plastic bottles can save enough energy to power a 60-watt light bulb for six hours."; break;   
            case 17: funFactText.text = "Steel is the most recycled material globally. It can be recycled repeatedly without losing its properties."; break;   
            case 18: funFactText.text = "The first Earth Day, celebrated on April 22, 1970, helped raise awareness about environmental issues, including the importance of recycling."; break; 
            case 19: funFactText.text = "Approximately 80% of a vehicle can be recycled."; break;
            
            case 20: funFactText.text = "The first plastic bottle recycling plant was established in 1972."; break;  
            case 21: funFactText.text = "By recycling, we can reduce the amount of waste that goes to landfills, which helps protect our environment and keeps our communities clean."; break;   
            case 22: funFactText.text = "Did you know that recycling one ton of cardboard can save over 9 cubic yards of landfill space? That's like saving a roomful of trash!"; break;   
            case 23: funFactText.text = "Recycling aluminum cans can be so efficient that they can be back on store shelves in as little as 60 days."; break;   
            case 24: funFactText.text = "Recycling one ton of plastic saves enough energy to power a car for about 3,000 miles. That's like driving from Los Angeles to New York City and back!"; break;   
            case 25: funFactText.text = "The energy saved from recycling one glass bottle can power a computer for 25 minutes. That's like watching an episode of your favorite show!"; break;   
            case 26: funFactText.text = "Did you know that old cell phones can be recycled? They contain valuable metals like gold and silver that can be extracted and reused."; break;   
            case 27: funFactText.text = "In some cities, garbage trucks are powered by natural gas made from the methane gas emitted by decomposing waste in landfills. It's a way to turn trash into fuel!"; break;   
            case 28: funFactText.text = "The world's largest recycled plastic bottle greenhouse is located in Wales, UK. It's made up of over 6,000 recycled plastic bottles!"; break; 
            case 29: funFactText.text = "The world's largest recycled sculpture is called \"Goddess of the Mediterranean,\" and it's made entirely out of recycled materials like car parts, bicycle chains, and discarded tools."; break;
            
            case 30: funFactText.text = "You can become a recycling superhero by spreading the word about recycling to your friends and classmates. Together, you can make a difference!"; break;  
            case 31: funFactText.text = "Recycling can be a family activity. Get your parents and siblings involved in sorting and recycling, and make it a fun challenge to see who can recycle the most."; break;   
            case 32: funFactText.text = "Some communities have recycling competitions where kids like you can get prizes for collecting the most recyclables. It's a fun way to get involved and make a positive impact."; break;   
            case 33: funFactText.text = "Recycling can be a creative activity too! You can turn old cardboard boxes into cool forts, or repurpose old jars into colorful pencil holders."; break;   
            case 34: funFactText.text = "Some toys are made from recycled materials, like plastic milk jugs. So, when you play with them, you're giving new life to old materials and having fun at the same time."; break;   
            case 35: funFactText.text = "By recycling, you're joining a global effort to protect wildlife habitats and ensure a cleaner environment for animals to thrive in."; break;   
            case 36: funFactText.text = "Recycling helps reduce the demand for raw materials, which in turn helps protect natural habitats and conserve biodiversity."; break;   
            case 37: funFactText.text = "In the United States, recycling and composting help prevent more than 180 million metric tons of carbon dioxide emissions annually."; break;   
            case 38: funFactText.text = "Recycling one ton of plastic bottles can save the equivalent energy of a two-person household for one year."; break; 
            case 39: funFactText.text = "Aluminum cans are one of the most valuable items to recycle. They can be melted down and turned into new cans in no time!"; break;
            
            case 40: funFactText.text = "Recycling one ton of plastic can save around 16.3 barrels of oil. That's like conserving enough oil to drive a car for about 1,600 miles."; break;  
            case 41: funFactText.text = "In some cities, there are creative recycling initiatives, like turning old shipping containers into community gardens or transforming retired buses into mobile recycling centers."; break;   
            case 42: funFactText.text = "The world's tallest recycling bin is located in Tokyo, Japan. It stands at about 33 feet (10 meters) tall!"; break;   
            case 43: funFactText.text = "In some places, you can recycle old clothes and textiles. They can be turned into new fabrics or used for things like insulation or stuffing for pillows and mattresses."; break;   
            case 44: funFactText.text = "Recycling old newspapers can help save energy. For example, recycling enough newspapers can save about 75,000 trees!"; break;   
            case 45: funFactText.text = "Recycling one ton of cardboard saves over 9 cubic yards of landfill space. That's enough to fill about seven pickup trucks!"; break;   
            case 46: funFactText.text = "Recycling e-waste helps recover valuable metals and prevents harmful substances from entering the environment."; break;   
            case 47: funFactText.text = "By recycling one ton of paper, we can save around 17 mature trees. That's like saving a small forest!"; break;   
            case 48: funFactText.text = "In some countries, like Norway, there's a recycling program where you can get a refund for returning empty beverage containers. It's like getting a reward for recycling!"; break; 
            case 49: funFactText.text = "Recycling is not just for paper, plastic, and metal. You can also recycle organic waste, like food scraps and yard trimmings, by composting. It turns into nutrient-rich soil for gardening."; break;
            
            case 50: funFactText.text = "Electronic waste, or e-waste, is the fastest-growing waste stream in the world. Recycling electronics helps recover valuable materials and prevents harmful substances from entering the environment."; break;  
            case 51: funFactText.text = "Many fashion brands are incorporating recycled materials, such as plastic bottles and reclaimed fabrics, into their clothing lines to promote sustainable fashion."; break;   
            case 52: funFactText.text = "Biodegradable plastics are being developed to provide environmentally friendly alternatives to traditional plastics, but they still require proper disposal and recycling."; break;   
            case 53: funFactText.text = "Recycling food waste through composting can help enrich the soil, reduce methane emissions from landfills, and promote sustainable agriculture."; break;   
            case 54: funFactText.text = "Some cities are implementing \"pay-as-you-throw\" programs, where residents are charged based on the amount of waste they generate, incentivizing recycling and waste reduction."; break;   
            case 55: funFactText.text = "When you recycle, you demonstrate your belief in a world where sustainability and responsible consumption are valued."; break;   
            case 56: funFactText.text = "Your small recycling efforts can have a big impact. Every recycled item counts, and collectively, they add up to significant environmental benefits."; break;   
            case 57: funFactText.text = "The simple act of recycling empowers you to be an agent of change and a champion for a greener future."; break;   
            case 58: funFactText.text = "Recycling is not just about waste management—it's a symbol of our responsibility and commitment to taking care of our planet and all its inhabitants."; break; 
            case 59: funFactText.text = "Every time you recycle, you are participating in a global effort to conserve resources, reduce pollution, and protect the Earth's ecosystems."; break;
            
       }
       
    }

    void activateSloMo()
    {
        float speedFactor = Random.Range(0.5f,0.9f);
        Time.timeScale = speedFactor;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
    }
}
