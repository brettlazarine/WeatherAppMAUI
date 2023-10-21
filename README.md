## **WeatherAppMAUI**

This project focuses on the consumption of *open-meteo's* API to create a weather app, led by Hector Perez on his Udemy course: *.NET MAUI course with Visual Studio 2022 creating PROJECTS*

The UI is formatted to display data by way of binding to API specific Class Properties, implementing a CollectionView to display the future forecast, and utilizes *LottieFiles* to provide users with dynamic weather icons:
- The styles for the controls are placed in the custom *AppStyles* ResourceDictionary
- *searchBar* uses its SearchCommand and SearchCommandParameter to activate the backend logic that calls the API and generates information to be displayed
- *LottieImages* and weather types are converted from *weathercode* to their appropriate animated images/values with *CodeToLottieConverter* and *CodeToWeatherConverter*
- The Controls are hidden by default, and *IsVisible* is toggled after the API call
- An ActivityIndicator is set within a Grid that has its IsVisible property bound to *IsLoading* that is toggled before and after the API call

The backend is powered by *WeatherViewModel*, and implements *Fody* for *INotifyPropertyChanged*:
- *SearchCommand* formats *PlaceName* such that the first letter of any word entered into *searchBar* is capitalized, calls *GetCoordinatesAsync()*, and calls *GetWeather()*
- *GetCoordinatesAsync()* implements the *Geocoding* Class and returns the location information (latitude and longitude in particular) of *location*
- *GetWeather()* then utilizes *location's* information (lat and long) in the API call to *open-meteo*
  - *IsLoading* is set to True, activating the ActivityIndicator and its Grid's UI properties
  - *response* retrieves the data from the API and, if successful, is subsequently deserialized and the contents applied to *WeatherData*
  - Because *WeatherData.daily* is a List of values, it is iterated through and the values for each day are assigned to *daily2*, which is then added to the *daily2* List for CollectionView
  - Finally, *IsVisible* is toggled to display all of the information returned from the API call and *IsLoading* is toggled to hide the ActivityIndicator and its Grid
- Both *CodeToWeatherConverter* and *CodeToLottieConverter* use Switch Cases to compare and change *weathercode* against the corresponding weather code found in the API's documentation
