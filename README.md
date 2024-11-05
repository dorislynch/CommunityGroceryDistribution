
# react-native-community-grocery-distribution

## Getting started

`$ npm install react-native-community-grocery-distribution --save`

### Mostly automatic installation

`$ react-native link react-native-community-grocery-distribution`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-community-grocery-distribution` and add `RNCommunityGroceryDistribution.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCommunityGroceryDistribution.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCommunityGroceryDistributionPackage;` to the imports at the top of the file
  - Add `new RNCommunityGroceryDistributionPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-community-grocery-distribution'
  	project(':react-native-community-grocery-distribution').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-community-grocery-distribution/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-community-grocery-distribution')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCommunityGroceryDistribution.sln` in `node_modules/react-native-community-grocery-distribution/windows/RNCommunityGroceryDistribution.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Community.Grocery.Distribution.RNCommunityGroceryDistribution;` to the usings at the top of the file
  - Add `new RNCommunityGroceryDistributionPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCommunityGroceryDistribution from 'react-native-community-grocery-distribution';

// TODO: What to do with the module?
RNCommunityGroceryDistribution;
```
  