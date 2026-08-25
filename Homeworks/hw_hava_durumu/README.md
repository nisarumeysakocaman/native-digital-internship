[🇹🇷 Türkçe](README.tr.md) | [🇬🇧 English](README.md)

### 🔄 Workflow Steps

1. **City Assignment:** The target city name is passed to a dynamic variable using the `Assign` activity.
2. **Web Browser Automation:** Google is launched via `Use Application/Browser`, the search query `[City Name] + weather` is automatically typed into the search bar, and the search is performed using the `Click` activity.
3. **Page Validation:** `Click` → `Verify` is used to confirm that the correct weather page and result elements have loaded.
4. **Data Extraction and Notification:** The current weather information is extracted from the page using `Get Text`, then:
   - Logged to system logs (`Log Message`)
   - Displayed to the user as a real-time notification (`Message Box`)
  
    - ![Uygulama Ekran Kaydı](assets/hw_hava_durumu_demo.gif)

 
