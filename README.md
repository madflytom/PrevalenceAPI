# IO.Swagger - ASP.NET Core 2.0 Server

The purpose is to provide a population prevalence for a given disease and country.  Using the country population and a disease prevalence factor, a potential patient population for the disease can be returned.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
