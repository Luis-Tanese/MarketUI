/*
        NOTICE: If your workshop images dont work, contact Tanese#5005 or tanese on discord

        IMPORTANT NOTE: You will need the following modules for the script to work:
        Widget Flags by F-Plugins | Download from Releases: https://github.com/F-Plugins/WidgetFlags-uScript
        Effect Manager Extended by RiceField-Plugins | Download from Releases: https://github.com/RiceField-Plugins/EffectManagerExtended-uScript
        ItemIdbyName by Tanese (WIP) | Download from Releases:

        Commands (players):
        /market
        /mkt
        /mk

        Commands (admins):
        /marketadmin
*/

/*
    ITEM INFORMATION
*/
WorkshopImages = [ // Workshop Ids for Items (Necessary if you want to use mods)
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
    VEHICLE INFORMATION
*/

WorkshopVehicleImages = [ // Workshop Ids for Items (Necessary if you want to use mods)
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

CustomVehicleImages = [ // Custom images for items. (if you dont need any just delete the arrays inside)
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

// Simple Configurations
useUconomy = false; // Set to true if you want to use uConomy

// Categories Configurations (Not recommended to turn off)
clothing = true; // If you want the clothign category
weapons = true; // If you want the weapons category
food = true; // If you want the food category
building = true; // If you want the building category
vehicles = true; // If you want the vehicles category
miscellaneous = true; // If you want the miscellaneous category


uiId = 17243; // Don't change (Only if you want a custom UI, contact tanese or benjaminmaigua in discord)

/*
    Translations
*/

translations = {
    "Market": "Market",
    "Price": "Price",
    "NothingForSale": "Nothing for sale here...",
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
    wait.seconds(10, packageinstall, "--------------------------------------------------");
    wait.seconds(10, packageinstall, "--------------------------------------------------");
    wait.seconds(10, packageinstall, "--  __  __            _        _     _   _ ___  --");
    wait.seconds(10, packageinstall, "-- |  \/  | __ _ _ __| | _____| |_  | | | |_ _| --");
    wait.seconds(10, packageinstall, "-- | |\/| |/ _` | '__| |/ / _ \ __| | | | || |  --");
    wait.seconds(10, packageinstall, "-- | |  | | (_| | |  |   <  __/ |_  | |_| || |  --");
    wait.seconds(10, packageinstall, "-- |_|  |_|\__,_|_|  |_|\_\___|\__|  \___/|___| --");
    wait.seconds(10, packageinstall, "--------------------------------------------------");
    wait.seconds(10, packageinstall, "--------------------------------------------------");
    wait.seconds(10, packageinstall, "--          ___     __          ____ _____      --");
    wait.seconds(10, packageinstall, "--         / \ \   / /    _    |  _ \_   _|     --");
    wait.seconds(10, packageinstall, "--        / _ \ \ / /   _| |_  | | | || |       --");
    wait.seconds(10, packageinstall, "--       / ___ \ V /   |_   _| | |_| || |       --");
    wait.seconds(10, packageinstall, "--      /_/   \_\_/      |_|   |____/ |_|       --");
    wait.seconds(10, packageinstall, "--------------------------------------------------");
    wait.seconds(10, packageinstall, "--------------------------------------------------");
    wait.seconds(10, databaseinstall);
}

function packageinstall(){
    server.log(message);
}

function databaseinstall(){
    database.firstRow("CREATE TABLE IF NOT EXISTS Market_AVDT(
    itemId INT NOT NULL DEFAULT 0,
    itemName VARCHAR(255) NOT NULL,
    category VARCHAR(255) NOT NULL,
    price INT NOT NULL DEFAULT 0
    );");
    foreach(itemType in dataStorageArray){
        dataStorage.set(itemType, null);
    }
    foreach(image in CustomImages){
        customImgs.set(image[0], image[1]);
    }
    foreach(workImage in WorkshopImages){
        for(i = workImage[1]; i <= workImage[2]; i++){
            workshopImgs.set(i, workImage[0].toString());
        }
    }
    foreach(vehicle in CustomVehicleImages){
        customVehicleImgs.set(vehicle[0], vehicle[1]);
    }
    foreach(workshopVehicle in WorkshopVehicleImages){
        for(i = workshopVehicle[1]; i <= workshopVehicle[2]; i++){
            workshopVehicleImgs.set(i, workshopVehicle[0].toString());
        }
    }
}

OfficialImageGetFormat = "https://raw.githubusercontent.com/Luis-Tanese/AV_ImageModule/main/ITEMS/Official/{0}.png"; 
WorkshopImageGetFormat = "https://raw.githubusercontent.com/Luis-Tanese/AV_ImageModule/main/ITEMS/Workshop/{0}/{1}.png";

OfficialVehicleImageGetFormat = "https://raw.githubusercontent.com/Luis-Tanese/AV_ImageModule/main/Official/{0}.png";
WorkshopVehicleImageGetFormat = "https://raw.githubusercontent.com/Luis-Tanese/AV_ImageModule/main/Workshop/{0}.png";

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

dataStorage = map();
workshopImgs = map();
customImgs = map();
customVehicleImgs = map();
workshopVehicleImgs = map();

dataStorageArray = [
    // Clothing
    "HAT",
    "PANTS",
    "SHIRT",
    "MASK",
    "BACKPACK",
    "VEST",
    "GLASSES",
    // Weapons
    "GUN",
    "MAGAZINE",
    "MELEE",
    "THROWABLE",
    // Attachments
    "SIGHT",
    "TACTICAL",
    "GRIP",
    "BARREL",
    "OPTIC",
    // Food
    "FOOD",
    "WATER",
    // Buildings
    "BARRICADE",
    "STORAGE",
    "FARM",
    "STRUCTURE",
    "TANK",
    "GENERATOR",
    "BOX",
    "LIBRARY",
    "SENTRY",
    "OIL_PUMP",
    // Miscellaneous
    "MEDICAL",
    "FUEL",
    "TOOL",
    "BEACON",
    "TRAP",
    "SUPPLY",
    "GROWER",
    "FISHER",
    "CLOUD",
    "MAP",
    "KEY",
    "DETONATOR",
    "CHARGE",
    "FILTER",
    "VEHICLE_REPAIR_TOOL",
    "TIRE",
    "COMPASS",
    "ARREST_START",
    "ARREST_END"
];

command romp(){
    permission = "market";
    allowedCaller = "player";
    execute(){
        player.setData("MarketAdmin", false);
        wait.seconds(0.3, sendUi, player);
    }
}

command marketadmin(){
    permission = "marketAdmin";
    allowedCaller = "player";
    execute(){
        player.setData("MarketAdmin", true);
        wait.seconds(0.3, sendUi, player);
    }
}

event onEffectButtonClicked(player, button){
    if(button == "ClothingButn"){
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "ClothingArea", "true");
    }
    if(button == "WeaponsButn"){
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

function getVehicleImageById(id){
	if(customVehicleImgs.containsKey(id)){
		return customVehicleImgs.get(id);
	}
	if(id < 190){
		return OfficialVehicleImageGetFormat.format(id);
	}
	else{
		return WorkshopVehicleImageGetFormat.format(workshopVehicleImgs.get(id),id);
	}
}

function getItemImageById(id){
	if(customImgs.containsKey(id)){
		return customImgs.get(id);
	}
	if(id < 190){
		return OfficialImageGetFormat.format(id);
	}
	else{
		return WorkshopImageGetFormat.format(workshopImages.get(id),id);
	}
}

function sendUi(player){
    if(player.getData("MarketAdmin") == true){
        EffectManagerExtended.setVisibility(player.id, uiId, "AdminArea", "true");
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "GunsArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "ClothingArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "VehicleArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "FoodArea", "false");
        WidgetFlags.show(player.id, "Modal");
        WidgetFlags.show(player.id, "NoBlur");
        if(clothing != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "ClothingButn", "false");
        }
        if(weapons != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "GunsButn", "false");
        }
        if(vehicles != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "VehiclesButn", "false");
        }
        if(foods != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "FoodsButn", "false");
        }
    }
    else{
        effectManager.sendUi(uiId, uiId, player.id);
        EffectManagerExtended.setVisibility(player.id, uiId, "AdminArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "MainArea", "true");
        EffectManagerExtended.setVisibility(player.id, uiId, "GunsArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "ClothingArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "VehicleArea", "false");
        EffectManagerExtended.setVisibility(player.id, uiId, "FoodArea", "false");
        WidgetFlags.show(player.id, "Modal");
        WidgetFlags.show(player.id, "NoBlur");
        if(clothing != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "ClothingButn", "false");
        }
        if(weapons != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "WeaponsButn", "false");
        }
        if(vehicles != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "VehiclesButn", "false");
        }
        if(foods != true){
            EffectManagerExtended.setVisibility(player.id, uiId, "FoodsButn", "false");
        }
    } 
}
