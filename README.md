FuelupPusher for Microsoft Power BI
=

The FuelupPusher is a commandline resource that utilizes the Microsoft Power BI REST APIs to push car fuelup information to a dataset in your Power BI account. Using this dataset you can create a dashboard that updates in real time with each new fuelup you add using the FuelupPusher.

### Example Dashboard ###
TODO: Coming soon...
    	
### Using the sample ###

1. Run the `FuelupPusher.exe` located in the root of the directory. If you're interested you can also open the solution and build/run in Visual Studio.
2. Enter the information that is prompted. Below is a table of information that is stored in the dataset. If you'd like to request more, feel free to submit a pull request or file a bug/feature request via GitHub.

### Dataset ###
| DataName        | Description   |  DataType | Calculated or Provided |
| -------------   | ------------- |---------- | ---------------------- |
| Miles           | Miles you've traveled since your last fuelup.  | Double | Provided |
| Gallons         | Gallons filled up during your last fuelup.  | Double | Provided |
| PricePerGallon  | The cost per gallon you paid for your fuelup.  | Double | Provided |
| FuelupDate      | The date you fueled up.  | DateTime | Provided |
| MPG             | The Miles per Gallon you achieved since your last fuelup. | Double | Calculated |
| TotalCost       | Total Cost of your fuelup. | Double | Calculated |
