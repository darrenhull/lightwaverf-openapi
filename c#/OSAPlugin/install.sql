CALL osae_sp_object_type_add ('LIGHTWAVERF','LightWaveRF Plugin','','PLUGIN',1,1,0,1);

CALL osae_sp_object_type_add ('LIGHTWAVERF DEVICE','LightWaveRF Device','','MULTILEVEL SWITCH',0,0,0,1);
CALL osae_sp_object_type_state_add ('ON','On','LIGHTWAVERF DEVICE');
CALL osae_sp_object_type_state_add ('OFF','On','LIGHTWAVERF DEVICE');
CALL osae_sp_object_type_event_add ('ON','On','LIGHTWAVERF DEVICE');
CALL osae_sp_object_type_event_add ('OFF','Off','LIGHTWAVERF DEVICE');
CALL osae_sp_object_type_method_add ('ON','On','LIGHTWAVERF DEVICE','','','','');
CALL osae_sp_object_type_method_add ('OFF','Off','LIGHTWAVERF DEVICE','','','','');
CALL osae_sp_object_type_method_add ('HEAT-ON','Heat-On','LIGHTWAVERF DEVICE','','','','');
CALL osae_sp_object_type_method_add ('HEAT-OFF','Heat-Off','LIGHTWAVERF DEVICE','','','','');
CALL osae_sp_object_type_property_add ('Room','Integer','','LIGHTWAVERF DEVICE',0);
CALL osae_sp_object_type_property_add ('Device','Integer','','LIGHTWAVERF DEVICE',0);