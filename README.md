# wafer-coating-simulation
Real-life wafer coating simulation

## Index
  
  - [About](#About) 
  - [Overview](#Overview)
  - [Details](#Details)
  - [To-dos](#To-dos)
  - [License](#License)



## About  
| Factory Panel                       | Waferline Panel                     |
| ----------------------------------- | ----------------------------------- |
| ![waferfactory](https://github.com/Aidenseo3180/wafer-coating-simulation/assets/66958352/e079b238-5b7a-488d-8853-a3a667c2bd08) | ![waferline](https://github.com/Aidenseo3180/wafer-coating-simulation/assets/66958352/47b38591-ddd2-4ca5-9458-f2ef2c02c862) |

A semiconductor wafer coating simulation with simplified process to better understand its structure and practice C# skillsets.

## Overview

The simulation consists of 2 main parts:  the waferline panel and the factory panel.   
The waferline panel displays the number of coated / uncoated wafers and the property of that line.  
The factory panel displays the number of waferlines within the factory.  
  
Bin, obj, properties, app.config excluded.  
Lib folders are dll.  

## Details

### Waferline Panel
The waferline panel displays the number of coated / uncoated wafers.
The number of uncoated wafers are given to waferline that consists of 1000 cells. The wafer line's job is to coat all the cells and mark it as coated.  
Once the cell is coated, it turns green. The more green it gets, the higher coating quality it has.  
The maximum quality that one cell can reach is a 100.  
  
Coating liquid is the number of liquid bottles that the waferline can utilize. Each bottle is capable of coating 1000 wafer cells.  
The spin rate and the drop rate are responsible of the coating speed. Increase / decreases these rates can lead to difference in the speed.  
Fully coated wafers can be viewed with its average quality.  

### Factory Panel
The factory panel allows the user to remotely control the wafer line.  
The user can select a certain waferline and view its properties from the number of uncoated / coated wafers to its spin / drop rate.  
  
It displays everything about the waferline on live. If the value in waferline changes, the values in factory panel also changes.  
It is also capable of displaying a certain coated wafer of the selected waferline.

## To-dos
- [ ] Supports connection through IP address

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

