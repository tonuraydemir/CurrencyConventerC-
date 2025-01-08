def main():
    exchange_rates = {
        "USD": 1.0,
        "EUR": 0.97,
        "TRY": 36.0,
        "GBP": 0.56,
        "KM": 1.93
    }

    while True:
        print("Welcome to the Currency Converter Application")
        print("Available Currencies: KM, TRY, USD, EUR, GBP")

        source_currency = input("Enter the source currency (e.g., KM): ").strip().upper()
        target_currency = input("Enter the target currency (e.g., TRY): ").strip().upper()
        
        try:
            amount = float(input("Amount: "))

            if source_currency in exchange_rates and target_currency in exchange_rates:
                source_rate = exchange_rates[source_currency]
                target_rate = exchange_rates[target_currency]

                result = amount * (target_rate / source_rate)
                print(f"{amount} {source_currency} = {result:.2f} {target_currency}")
                input("Logged Out... Press Enter to proceed to the next operation.")
            else:
                print("Invalid currency codes. Please try again.")
                input("Press Enter to continue.")
        except ValueError:
            print("Invalid amount. Please enter a valid number.")
            input("Press Enter to continue.")

if __name__ == "__main__":
    main()
