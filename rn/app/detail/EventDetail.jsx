import { View, Text, ScrollView } from "react-native"
import React from "react"
import { Ionicons } from "@expo/vector-icons"

const EventDetail = () => {
  return (
    <ScrollView className='flex-1'>
      <View>
        <Ionicons name='arrow-back' size={24} color='black' />
        <Text>EventDetail</Text>
      </View>
    </ScrollView>
  )
}

export default EventDetail
