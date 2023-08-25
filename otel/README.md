# OpenTelemetry

This folder contains a preconfigured docker compose file for local experiments
with OpenTelemetry. It includes a OpenTelemetry collector, a Jaeger UI, Prometheus
and Grafana.

To start it use the following command:

```bash
docker-compose --env-file .env up --no-build
```

The collector is preconfigured to export metric, traces and log entries to NewRelic.
In order to activate it add your NewRelic api key to the `.env` file and restart the
containers.