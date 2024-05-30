# Defs
Topmost node in files in the Defs folder.  Everything starts here.
## ThingDef
A definition of a thing.  One of these for each new thing you want to add.
1. defName - A unique name for the thing.  Will not be visible to the user.  Must follow the format [ModName]_[ItemName].
1. label - The name for that items that will be displayed in game.
1. description ? A description for the item that will be displayed in game
1. graphicData
    1. texPath ? Path to the image file that will be used to represent this thing in the game world.  Relative path, starting from within the 'Textures' folder.
    1. graphicClass ? Maybe specifies when to use the graphic
        - Graphic_Single ? Used when drawing a single item
        - ???
1. stackLimit ? Limit of how many of this thing can exist in a single stack
1. category ?? maps to a ThingCategoryDef by way of defName
1. thingClass ??? 
1. statBases
    1. MarketValue ? Value of the item at the market.
1. smeltable ? Whether or not the item can be smelted.
1. weaponClasses ? 


## ThingCategoryDef (file:///G:/steam/steamapps/common/RimWorld/Data/Core/Defs/ThingCategoryDefs/ThingCategories.xml)
A definition for a category of items.  Probably has to do with listing them in the stockpile summary, and when browsing for them in the stockpile details.
1. defName ? A unique name for the category.  Not displayed to the user.  Referenced in ThingDef.category.
1. label ? Probably the displayed name of the category when looking at stockpile lists.
1. iconPath ? The location of an image that will be displayed in stockpile readouts.
1. resourceReadoutRoot ? Controls where the category is displayed in the root of the resource readouts
    - false [default] - is not displayed
    - true - is displayed


## WeaponClassDefs (file:///G:/steam/steamapps/common/RimWorld/Data/Core/Defs/WeaponClassDefs/WeaponClassDefs.xml)
A definition for weapon classes.  These are referred to in ThingDefs for weapons.  They are probably used to identify preferences for styles of weapons such as for Brawlers and technophiles.  They may also be referenced when identifying which skills work with which weapons.  Maybe more.
1. defName ? A unique name for the class.  Not displayed to the user.  Referenced in 