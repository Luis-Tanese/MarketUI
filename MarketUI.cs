/*
        NOTICE: If your workshop images dont work, contact Tanese#5005 or tanese on discord to add 

        Commands (players):
        /market
        /mkt
        /mk

        Commands (admins):
        /marketadmin
*/

WorkshopIma ges = [ // Workshop Ids for Items (Necessary if you want to use mods)
    [
        2710798455, // WORKSHOP_ID
        45100, // LOWEST_ID
        45137 // HIGHEST_ID
    ],
    [
        2930460896, // WORKSHOP_ID
        26431, // LOWEST_ID
        26431 // HIGHEST_ID
    ],
    [
        2955811332, // WORKSHOP_ID
        27000, // LOWEST_ID
        27099 // HIGHEST_ID
    ]
];

CustomImages = [ // Custom images for items. (if you dont need any just delete the arrays inside)
    [
        22, // ITEM_ID
        "https://i.imgur.com/SFdYgXJ.png" // IMAGE_URL
    ],
    [
        23, // ITEM_ID
        "https://i.imgur.com/SFdYgXJ.png" // IMAGE_URL
    ],
    [
        24, // ITEM_ID
        "https://i.imgur.com/SFdYgXJ.png" // IMAGE_URL
    ]
];

/*
    Configuration:
*/

useUconomy = false; // Set to true if you want to use uConomy
clothing = true; // If you want the clothign category
guns = true; // If you want the guns category
vehicles = true; // If you want the vehicles category
foods = true; // If you want the foods category


uiId = 17243;

/*
    Translations
*/

translations = {
    "Market": "Market",
    "Price": "Price",
    "": "",
}





























































event onLoad(){
    serverpackageinstall();
}

function serverpackageinstall(){
    wait.seconds(0.5, packageinstall, "Market UI: Installing Packages 1/18");
    wait.seconds(1.2, packageinstall, "Market UI: Installing Packages 2/18");
    wait.seconds(2.3, packageinstall, "Market UI: Installing Packages 3/18");
    wait.seconds(3, packageinstall, "Market UI: Installing Packages 4/18");
    wait.seconds(3.5, packageinstall, "Market UI: Installing Packages 5/18");
    wait.seconds(4, packageinstall, "Market UI: Installing Packages 6/18");
    wait.seconds(4.3, packageinstall, "Market UI: Installing Packages 7/18");
    wait.seconds(4.9, packageinstall, "Market UI: Installing Packages 8/18");
    wait.seconds(5, packageinstall, "Market UI: Installing Packages 9/18");
    wait.seconds(5.2, packageinstall, "Market UI: Installing Packages 10/18");
    wait.seconds(5.6, packageinstall, "Market UI: Installing Packages 11/18");
    wait.seconds(5.9, packageinstall, "Market UI: Installing Packages 12/18");
    wait.seconds(6, packageinstall, "Market UI: Installing Packages 13/18");
    wait.seconds(6.2, packageinstall, "Market UI: Installing Packages 14/18");
    wait.seconds(6.7, packageinstall, "Market UI: Installing Packages 15/18");
    wait.seconds(7, packageinstall, "Market UI: Installing Packages 16/18");
    wait.seconds(8, packageinstall, "Market UI: Installing Packages 17/18");
    wait.seconds(9, packageinstall, "Market UI: Installing Packages 18/18");
    wait.seconds(10, packageinstall, "Market UI: Package Instalation Completed");
    wait.seconds(10, packageinstall, "------------------------------------------------");
    wait.seconds(10, packageinstall, "------------------------------------------------");
    wait.seconds(10, packageinstall, "-- __  __            _        _     _   _ ___ --");
    wait.seconds(10, packageinstall, "--|  \/  | __ _ _ __| | _____| |_  | | | |_ _|--");
    wait.seconds(10, packageinstall, "--| |\/| |/ _` | '__| |/ / _ \ __| | | | || | --");
    wait.seconds(10, packageinstall, "--| |  | | (_| | |  |   <  __/ |_  | |_| || | --");
    wait.seconds(10, packageinstall, "--|_|  |_|\__,_|_|  |_|\_\___|\__|  \___/|___|--");
    wait.seconds(10, packageinstall, "------------------------------------------------");
    wait.seconds(10, packageinstall, "------------------------------------------------");
    wait.seconds(10, packageinstall, "--         ___     __          ____ _____     --");
    wait.seconds(10, packageinstall, "--        / \ \   / /    _    |  _ \_   _|    --");
    wait.seconds(10, packageinstall, "--       / _ \ \ / /   _| |_  | | | || |      --");
    wait.seconds(10, packageinstall, "--      / ___ \ V /   |_   _| | |_| || |      --");
    wait.seconds(10, packageinstall, "--     /_/   \_\_/      |_|   |____/ |_|      --");
    wait.seconds(10, packageinstall, "------------------------------------------------");
    wait.seconds(10, packageinstall, "------------------------------------------------");
    wait.seconds(10, databaseinstall);
}

function packageinstall(){
    server.log(message);
}

function databaseinstall(){
    database.firstRow("CREATE TABLE IF NOT EXISTS Market_AVDT(
    itemId INT NOT NULL DEFAULT 0,
    itemName VARCHAR(255) NOT NULL,
    Price INT NOT NULL DEFAULT 0
    );");
}

function decreaseBalance(player, amount){
    if(useUconomy == true){
        if(player.balance < amount){
            return false;
        }
        else{
            player.balance -= amount;
            return true;
        }
    }
    else{
        if(player.experience < amount){
            return false;
        }
        else{
            player.experience -= amount;
            return true;
        }
    }
}

function increaseBalance(player, amount){
    if(useUconomy == true){
        player.balance += amount;
    }
    else{
        player.experience += amount;
    }
}

command market(){
    permission = "market";
    allowedCaller = "player";
    execute(){
        player.sudo("/romp")
    }
}
command mkt(){
    permission = "market";
    allowedCaller = "player";
    execute(){
        player.sudo("/romp")
    }
}
command mk(){
    permission = "market";
    allowedCaller = "player";
    execute(){
        player.sudo("/romp")
    }
}


command romp(){
    permission = "market";
    allowedCaller = "player";
    execute(){
        effectManager.sendUI(uiId, uiId, player.id);
        player.setData("MarketAdmin", false);
        EffectManagerExtended.setVisibility(player.id, uiId, "AdminArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "true");
        EffectManagerExtended.setVisibility(player.id, uiId, "GunsArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "ClothingArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "VehicleArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "FoodArea", "false");
        
        if(clothing != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "ClothingButn", "false");
        }
        if(guns != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "GunsButn", "false");
        }
        if(vehicles != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "VehiclesButn", "false");
        }
        if(foods != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "FoodsButn", "false");
        }
    }
}

command marketadmin(){
    permission = "marketAdmin";
    allowedCaller = "player";
    execute(){
        player.setData("MarketAdmin", true);
        effectManager.sendUI(uiId, uiId, player.id);
        EffectManagerExtended.setVisibility(player.id, uiId, "AdminArea", "true");
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "GunsArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "ClothingArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "VehicleArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "FoodArea", "false");
    }
}

event onEffectButtonClicked(player, button){
    if(button == "ClothingButn"){
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "ClothingArea", "true");
    }
    if(button == "GunsButn"){
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "GunsArea", "true");
    }
    if(button == "VehiclesButn"){
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "VehicleArea", "true");
    }
    if(button == "FoodButn"){
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "FoodArea", "true");
    }
}
