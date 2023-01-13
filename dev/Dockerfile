FROM mcr.microsoft.com/dotnet/sdk:6.0

RUN useradd -m -s $(which bash) develop

RUN mkdir /app && chown develop:develop /app

USER develop