FROM ghcr.io/danopstech/grafana:latest

USER root

COPY ./data/grafana /var/lib/grafana

RUN chown -R 472:0 /var/lib/grafana

COPY ./config/grafana/provisioning /etc/grafana/provisioning/

RUN chown -R 472:0 /etc/grafana/provisioning

USER 472

ENTRYPOINT ["/run.sh"]