# Design Pattern Sample
Design Pattern 一詞最早出現在 Gof (Gang of Four, GoF) 的著作中, 在軟體設計的領域中, 針對反覆出現的問題所歸納出的解決方法.

設計模式一共有23種, 依照性質又可以分成三大類:

| Creational Pattern    | Structural Pattern    | Behavioral Pattern
| :------               | :------               | :------
| Factory Method        | Adapter               | Interpreter
| Abstract Factory      | Bridge                | Template Method
| Builder               | Composite             | Command
| Protype               | Decorator             | Iterator
| Singleton             | Facade                | Mediator
|                       | Flyweight             | Memento
|                       | Proxy                 | Observer
|                       |                       | State
|                       |                       | Strategy
|                       |                       | Chain of Responsibility
|                       |                       | Visitor

***

# A. Facade

為複雜的系統定義一個抽象, 呼叫端透過這個抽象操作, 可降低呼叫端對複雜系統的依賴也可以更容易地使用該複雜的系統.


# B. Adapter

將既有類別的抽象轉成另一種抽象, 讓原本不能一起工作的類別因為有共同的抽象而可以共同工作. 實務上可能碰上既有類別來自第三方函式庫, 該類別無法變更抽象或是更本就沒有抽象.


# C. Singleton

確保只有單一實例存在.


# D. Factory Method

定義一個抽象, 產生實例的工作交由該抽象的實作類別執行, 外部由此抽象獲得實例, 可降低外部對實作類別的耦合度. 根據實作方式又可以分為參數化的 Simple Factory 及泛型化的 Generic Factory.

其中 Simple Factory 因為有分支的問體, 可以選擇用資源搜尋法或是 Attribute 的方式決定要建立哪種實作類別的實例. 實作方式又可以選擇 Enum 對應 Type 或是 Enum 對應 Constructor Delegate.

其中 Generic Factory 由外部直接傳入 AssemblyName 及 TypeName, 因其已經暴露太多訊息, 故實務上比較少用到, 另外 Generic Factory 可用來自建 DI 容器.


# E. Abstract Factory

針對一整族相關的物件定義抽象, 外部透過該抽象取得一整族物件, 而不需要指定他們的型別, 適用於整族切換.

產品的一般化依照垂直關係定義抽象(從屬關係), 如手機與充電器.

工廠的一般化依照水平關係定義抽象(非從屬關係), 如第一世代與第二世代.


# F. Template Method

在抽象中定義操作步驟, 步驟的具體邏輯遞延到子類別, 如此可以再不改變步驟的前提下, 改變具體邏輯.


# G. Strategy

實作類別實作同一個抽象, 操作時透過抽象操作, 從而使得實作的邏輯由外部傳入, 繼而達成可以任意替換的目標.

# H. Chain Of Responsibility

將處理邏輯封裝成物件, 並依業務邏輯組成鏈, 需要處理的需求依照此鏈傳遞, 直到鏈中的物件處理需求為止, 透過這樣的方式可以避免需求發送端與處理端的耦合.

鏈太長會有效能問題偵錯也會更為困難, 但比起巢狀判斷式仍然簡單許多.


# I. State

讓物件自己決定狀態的轉變, 而非由外部進行判斷後再改變其狀態, 由此降低複雜度.

    狀態模式要處理的是, 自己就知道要怎麼改變的話, 就不要由外部告知. 
    責任鏈模式是處理內部就知道動作的處理流程的話不要由外部告知. 
    策略模式則是處理上述, 內部未知狀況之不確定性. 


# J. Prototype

透過複製的方式降低建立複雜實例的難度, C# 有很多語法糖導致 Prototype 的效用不是那麼明顯, 如物件初始設定式.

目前主要的用途在記錄 runtime 時期的資料, 實務上常與 Memo 搭配使用.

Dotnet 內建 ICloneable Interface.


# K. Memento

在不破壞物件封裝的狀況下, 捕捉物件內部狀態, 並保存於物件之外, 如此就可以在物件改變狀態之後進行恢復。

應用場景不見得只在應用程式開發上, 在行動裝置的作業系統上, 可以暫時跳出應用程式, 之後再回來繼續進行, 此即為應用 Memento 將應用程式的狀態保存, 並視需要進行恢復。


# L. Decorator

為物件動態擴充空能且可以層層套疊, 注意, 是將職責加入到實例而非類別, 很符合 OOP 擴充的特性。

舊有的物件即便不可修改程式碼也可以透過 Adapter 來持有共同抽象以完成 Decorator。


# M. Proxy

透過一物件操作目標物件, 透過這種方式以取代原本的功能, 並加入額外功能。此處示範 Transparent Proxy

1. Remote Proxy
2. virtual Proxy
3. Protectuib Proxy
4. Smart Reference

Proxy 與 Decorator 很像, 有時分別不會那麼明顯, 例如要在某個物件上加 Log。但 Proxy 不會像 Decorator 層層套疊。Proxy 關注的是對原有類別的代理, Proxy 可完全取代原有類別。Decorator 關注擴充原有類別。


# M. Builder

將物件建立的過程抽象, 使得同樣的建立過程可以有不同的配置。

Fatory 關注的是集中建立 Instance。

Builder 關注的是建立的子模組及建立流程。